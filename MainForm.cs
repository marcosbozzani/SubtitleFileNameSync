using Ookii.Dialogs.WinForms;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SubtitleFileNameSync
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            lblBuild.Text = $"{BuildConfig.BuildDate} ({BuildConfig.BuildType})";
        }

        private static string[] videosExtentions = { ".mp4", ".mkv", ".avi" };
        private static string[] subtitlesExtentions = { ".srt" };

        private string lastVideosPath = null;
        private string lastSubtitlesPath = null;

        private void btnMoviesFolder_Click(object sender, EventArgs e)
        {
            PopulateList(lstVideos, videosExtentions, ref lastVideosPath);
        }

        private void btnOriginalSubtitlesFolder_Click(object sender, EventArgs e)
        {
            PopulateList(lstSubtitles, subtitlesExtentions, ref lastSubtitlesPath);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var result = SaveSubtitles();
            MessageBox.Show(result.Message);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstVideos.Items.Clear();
            lstSubtitles.Items.Clear();
        }

        private void PopulateList(ListBox listBox, string[] extensions, ref string lastPath)
        {
            using (var dialog = new VistaFolderBrowserDialog())
            {
                if (Directory.Exists(lastPath))
                {
                    dialog.SelectedPath = lastPath;
                }
                DialogResult result = dialog.ShowDialog(this);

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
                {
                    lastPath = dialog.SelectedPath;
                    var di = new DirectoryInfo(dialog.SelectedPath);
                    var files = di.GetFiles();
                    listBox.Items.Clear();

                    foreach (var file in files.OrderBy(x => x.Name))
                    {
                        foreach (var extension in extensions)
                        {
                            if (file.Name.EndsWith(extension))
                            {
                                listBox.Items.Add(file.FullName);
                                break;
                            }
                        }
                    }
                }
            }
        }

        private Result SaveSubtitles()
        {
            if (lstVideos.Items.Count == 0)
            {
                return Result.Failed("Select videos folder");
            }

            if (lstSubtitles.Items.Count == 0)
            {
                return Result.Failed("Select subtitles folder");
            }

            if (lstVideos.Items.Count != lstSubtitles.Items.Count)
            {
                return Result.Failed("Videos and subtitles count doesn't match");
            }

            for (int i = 0; i < lstVideos.Items.Count; i++)
            {
                var video = (string)lstVideos.Items[i];
                var subtitle = (string)lstSubtitles.Items[i];

                File.Copy(subtitle, video + ".srt", true);
            }

            return Result.Ok("Subtitles created");
        }

        private void listBox_MouseDown(object sender, MouseEventArgs e)
        {
            var listBox = (ListBox)sender;
            if (listBox.SelectedItem == null) return;
            listBox.DoDragDrop(listBox.SelectedItem, DragDropEffects.Move);
        }

        private void listBox_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void listBox_DragDrop(object sender, DragEventArgs e)
        {
            var listBox = (ListBox)sender;
            Point point = listBox.PointToClient(new Point(e.X, e.Y));
            int index = listBox.IndexFromPoint(point);
            if (index < 0) index = listBox.Items.Count - 1;
            object data = listBox.SelectedItem;
            listBox.Items.Remove(data);
            listBox.Items.Insert(index, data);
        }
    }
}
