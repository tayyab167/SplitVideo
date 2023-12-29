using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SplitVideo
{
    public partial class Enter_Video : Form
    {
        public Enter_Video()
        {
            InitializeComponent();
            label7.Hide();
        }

        private void Convert_Click(object sender, EventArgs e)
        {
            string InputfilePath = txtVideoPath.Text;

            if (InputfilePath != null && !File.Exists(InputfilePath))
            {
                MessageBox.Show("input File is not valid.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if validation fails
            }
            // Validate output directory
            if (string.IsNullOrEmpty(txtOutPutDirectory.Text.Trim()))
            {
                MessageBox.Show("Output directory cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if validation fails
            }

            if (Hours.Value == 0 && Minutes.Value == 0 && Seconds.Value == 0)
            {
                MessageBox.Show("Please enter Split Time Value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if validation fails
            }
            // Validate Hours
            if (Hours.Value < 0 || Hours.Value > 24)
            {
                MessageBox.Show("Please enter a value between 1 and 24 for hours.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if validation fails
            }

            // Validate Minutes
            if (Minutes.Value < 0 || Minutes.Value > 60)
            {
                MessageBox.Show("Please enter a value between 1 and 59 for minutes.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if validation fails
            }

            // Validate Seconds
            if (Seconds.Value < 0 || Seconds.Value > 60)
            {
                MessageBox.Show("Please enter a value between 1 and 59 for seconds.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if validation fails
            }

            label7.Show();

            List<string> FilesList = new List<string>();
            string projectFolder = AppDomain.CurrentDomain.BaseDirectory; // Get the project folder
            string FileExtension = Path.GetExtension(InputfilePath);
            string FolderName = "Video-" + DateTime.Now.ToString("yyyyMMddHHmmss");
            string outPutFolderPath = txtOutPutDirectory.Text + "\\" + FolderName;
            string outPutFolderPathSplitVideo = txtOutPutDirectory.Text + "\\" + FolderName + "\\Split";
            string outPutPathSplitVideo = outPutFolderPathSplitVideo + "\\Split" + "%%03d" + FileExtension;
            string outPutFolderPathJoinedVideos = txtOutPutDirectory.Text + "\\" + FolderName + "\\Converted Videos";
            try
            {
                Directory.CreateDirectory(outPutFolderPath);
                Directory.CreateDirectory(outPutFolderPathSplitVideo);
                Directory.CreateDirectory(outPutFolderPathJoinedVideos);
                if (!SplitVideo(outPutPathSplitVideo, outPutFolderPath))
                {
                    label7.Hide();
                    return;
                }

                string txtFilePath = Path.Combine(outPutFolderPath, "input.txt"); // Combine project folder with the batch file name

                FilesList = GetFileNames(outPutFolderPathSplitVideo);
                int Count = FilesList.Count();
                int i = 0;
                while (Count > 0)
                {
                    i++;
                    string firstElement = FilesList[0];
                    FilesList.RemoveAt(0);
                    FilesList.Add(firstElement);
                    if (CreatetxtFile(FilesList, txtFilePath))
                    {
                        string outputPath = outPutFolderPathJoinedVideos + "\\Video" + i + FileExtension;
                        string ffmpegCommand1 = @"@echo off
                                  ffmpeg -f concat -safe 0 -i """ + txtFilePath + @""" -c copy """ + outputPath + @"""";

                        string batchScriptPath1 = Path.Combine(outPutFolderPath, "RunFFMpeg.bat"); // Combine project folder with the batch file name

                        System.IO.File.WriteAllText(batchScriptPath1, ffmpegCommand1, Encoding.Default);

                        ProcessStartInfo psii = new ProcessStartInfo
                        {
                            FileName = batchScriptPath1,
                            UseShellExecute = true,
                            CreateNoWindow = true,
                            WindowStyle = ProcessWindowStyle.Hidden, // Set to Hidden
                            //WorkingDirectory = @"D:\VideoIteraror" // Set the working directory if needed
                        };
                        using (Process process = new Process { StartInfo = psii })
                        {
                            process.Start();
                            process.WaitForExit();
                            if (process.ExitCode != 0)
                            {
                                MessageBox.Show(process.ExitCode + " Join of the video Failed", "Join Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                label7.Hide();
                                if (File.Exists(batchScriptPath1))
                                {
                                    File.Delete(batchScriptPath1);
                                }
                                return;
                            }
                            if (File.Exists(batchScriptPath1))
                            {
                                File.Delete(batchScriptPath1);
                            }
                        }
                    }
                    Count--;
                }

                if (File.Exists(txtFilePath))
                {
                    File.Delete(txtFilePath);
                }
                label7.Hide();
                if (System.IO.Directory.Exists(outPutFolderPath))
                {
                    // Use Process.Start to open the directory in File Explorer
                    Process.Start("explorer.exe", outPutFolderPath);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                label7.Hide();
                return;
            }
        }
        private bool SplitVideo(string outPutPath, string path)
        {
            string ffmpegCommand = @"@echo off
                                  ffmpeg -i """ + txtVideoPath.Text + @""" -c copy -map 0 -segment_time " + TimeConvert() + @" -f segment -reset_timestamps 1 """ + outPutPath + @"""";

            string batchScriptPath = Path.Combine(path, "RunFFMpeg1.bat"); // Combine project folder with the batch file name

            if (File.Exists(batchScriptPath))
            {
                File.Delete(batchScriptPath);
            }

            System.IO.File.WriteAllText(batchScriptPath, ffmpegCommand, Encoding.Default);

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = batchScriptPath,
                UseShellExecute = true,
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden, // Set to Hidden
                //WorkingDirectory = @"D:\VideoIteraror" // Set the working directory if needed
            };

            using (Process process = new Process { StartInfo = psi })
            {
                process.Start();
                process.WaitForExit();

                if (process.ExitCode != 0)
                {
                    MessageBox.Show(process.ExitCode + " split of the video Failed", "Join Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (File.Exists(batchScriptPath))
                {
                    File.Delete(batchScriptPath);
                }
                return true;

            }

        }
        private bool CreatetxtFile(List<string> filePaths, string txtFilePath)
        {
            try
            {
                if (File.Exists(txtFilePath))
                {
                    File.Delete(txtFilePath);
                }
                string formattedPaths = string.Join(Environment.NewLine, filePaths.Select(filePath => $"file '{filePath}'"));
                System.IO.File.WriteAllText(txtFilePath, formattedPaths, Encoding.Default);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        private string TimeConvert()
        {
            int Hour = (int)Hours.Value; // Replace with your actual hour value
            int Mint = (int)Minutes.Value; // Replace with your actual minute value
            int Sec = (int)Seconds.Value; // Replace with your actual minute value
            string FormatTimeComponent(int value)
            {
                if (value < 0 || value > 59)
                {
                    return "00"; // Default value for invalid component
                }
                return value.ToString("D2");
            }

            // Ensure that hours, minutes, and seconds are within valid ranges
            Hour = (Hour >= 0 && Hour <= 23) ? Hour : 0;
            Mint = (Mint >= 0 && Mint <= 59) ? Mint : 0;
            Sec = (Sec >= 0 && Sec <= 59) ? Sec : 0;

            // Format the time string
            return $"{FormatTimeComponent(Hour)}:{FormatTimeComponent(Mint)}:{FormatTimeComponent(Sec)}";

        }
        private List<string> GetFileNames(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);

            if (directory.Exists)
            {
                return directory.GetFiles()
                    .OrderBy(f => f.LastWriteTime) // Order by date and time
                    .ThenBy(f => f.Name) // Then order by name
                    .Select(f => f.FullName) // Get full file paths
                    .ToList();


            }
            else
            {
                throw new Exception();
            }
        }

        private void btnChoseValue_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set the title of the dialog
            openFileDialog.Title = "Open Video File";

            // Filter for video file extensions (e.g., .mp4, .avi, .mkv)
            openFileDialog.Filter = "Video Files|*.mp4;*.avi;*.mkv|All Files|*.*";

            // Allow the user to select multiple files if needed
            openFileDialog.Multiselect = false;

            // Show the dialog and check if the user clicked the OK button
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file's full path (including extension)
                string selectedFilePath = openFileDialog.FileName;
                txtVideoPath.Text = selectedFilePath;
                // Now you can use the selectedFilePath as needed in your application
            }
        }
        private void btnOutputDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            // Set the title of the folder dialog
            folderBrowserDialog.Description = "Select Output Folder";

            // Show the dialog and check if the user clicked the OK button
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected folder's path
                string selectedFolderPath = folderBrowserDialog.SelectedPath;
                txtOutPutDirectory.Text = selectedFolderPath;
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConvertAndJoin_Click(object sender, EventArgs e)
        {
            string InputfilePath = txtVideoPath.Text;

            if (InputfilePath != null && !File.Exists(InputfilePath))
            {
                MessageBox.Show("input File is not valid.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if validation fails
            }
            // Validate output directory
            if (string.IsNullOrEmpty(txtOutPutDirectory.Text.Trim()))
            {
                MessageBox.Show("Output directory cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if validation fails
            }

            if (Hours.Value == 0 && Minutes.Value == 0 && Seconds.Value == 0)
            {
                MessageBox.Show("Please enter Split Time Value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if validation fails
            }
            // Validate Hours
            if (Hours.Value < 0 || Hours.Value > 24)
            {
                MessageBox.Show("Please enter a value between 1 and 24 for hours.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if validation fails
            }

            // Validate Minutes
            if (Minutes.Value < 0 || Minutes.Value > 60)
            {
                MessageBox.Show("Please enter a value between 1 and 59 for minutes.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if validation fails
            }

            // Validate Seconds
            if (Seconds.Value < 0 || Seconds.Value > 60)
            {
                MessageBox.Show("Please enter a value between 1 and 59 for seconds.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if validation fails
            }

            string FileExtension = Path.GetExtension(InputfilePath);
            string FolderName = "Video-" + DateTime.Now.ToString("yyyyMMddHHmmss");
            string outPutFolderPath = txtOutPutDirectory.Text + "\\" + FolderName;
            string outPutFolderPathSplitVideo = txtOutPutDirectory.Text + "\\" + FolderName + "\\Split";
            string outPutPathSplitVideo = outPutFolderPathSplitVideo + "\\Split" + "%%03d" + FileExtension;
            //string outPutFolderPathJoinedVideos = txtOutPutDirectory.Text + "\\" + FolderName+"\\Converted Videos";
            try
            {
                Directory.CreateDirectory(outPutFolderPath);
                Directory.CreateDirectory(outPutFolderPathSplitVideo);
                //Directory.CreateDirectory(outPutFolderPathJoinedVideos);
                SplitVideo(outPutPathSplitVideo, outPutFolderPath);
                if (System.IO.Directory.Exists(outPutFolderPathSplitVideo))
                {
                    // Use Process.Start to open the directory in File Explorer
                    Process.Start("explorer.exe", outPutFolderPathSplitVideo);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                label7.Hide();
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
