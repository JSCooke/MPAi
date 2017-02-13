﻿using MPAi.Cores;
using MPAi.Cores.Scoreboard;
using MPAi.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MPAi.Forms
{
    public partial class MPAiSoundMainMenu : Form, MainFormInterface
    {
        private bool appClosing = true;

        public MPAiSoundMainMenu()
        {
            InitializeComponent();

            // Disable score report button if the report has not been created before.
            ensureScoreReportButtonCorrectlyEnabled();

            string name = UserManagement.CurrentUser.GetCorrectlyCapitalisedName();

            if (name == null)
            {
                greetingLabel.Text = "Kia Ora, User!";
            }
            else
            {
                greetingLabel.Text = "Kia Ora, " + name + "!";
            }
        }

        private void ensureScoreReportButtonCorrectlyEnabled()
        {
            if (UserManagement.CurrentUser.SoundScoreboard.IsEmpty())
            {
                reportButton.Enabled = false;
            }
            else
            {
                reportButton.Enabled = true;
            }
        }

        /// <summary>
        /// When the user changes their voice settings, take this action.
        /// </summary>
        public void userChanged()
        {
            // No action taken.
        }

        /// <summary>
        /// Fires when the form closes. 
        /// If the user pressed the back button, the next form will be loaded. 
        /// If the user closed the form in some other way, the app will temrinate.
        /// </summary>
        /// <param name="sender">Automatically generated by Visual Studio.</param>
        /// <param name="e">Automatically generated by Visual Studio.</param>
        private void MPAiSoundMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (appClosing)
            {
                UserManagement.WriteSettings();
                Properties.Settings.Default.Save();
                Application.Exit();
            }
        }

        /// <summary>
        /// Shows the learning aid for MPAi Sound - the Video Player.
        /// </summary>
        /// <param name="sender">Automatically generated by Visual Studio.</param>
        /// <param name="e">Automatically generated by Visual Studio.</param>
        private void learnButton_Click(object sender, EventArgs e)
        {
            new VideoPlayer().Show();
            closeThis();
        }

        /// <summary>
        /// Shows the testing aid for MPAi Sound - the Formant Plot Test.
        /// </summary>
        /// <param name="sender">Automatically generated by Visual Studio.</param>
        /// <param name="e">Automatically generated by Visual Studio.</param>
        private void testButton_Click(object sender, EventArgs e)
        {
            MPAiUser user = UserManagement.CurrentUser;
            PlotController.PlotType? plotType = PlotController.PlotType.VOWEL_PLOT;
            VoiceType? voiceType = user.Voice;
            PlotController.RunPlot(plotType, voiceType);

           
            closeThis();
        }

        /// <summary>
        /// Closes the form, but not the application.
        /// </summary>
        public void closeThis()
        {
            appClosing = false; // Tell the FormClosing event not to end the program.
            Close();
        }
        /// <summary>
        /// Launches the score report in the user's default browser.
        /// </summary>
        /// <param name="sender">Automatically generated by Visual Studio.</param>
        /// <param name="e">Automatically generated by Visual Studio.</param>
        private void reportButton_Click(object sender, EventArgs e)
        {
            ReportLauncher.GenerateMPAiSoundScoreHTML(UserManagement.CurrentUser.SoundScoreboard);
            if (File.Exists(ReportLauncher.MPAiSoundScoreReportHTMLAddress))
            {
                ReportLauncher.ShowMPAiSoundScoreReport();
            }
        }

        private void formantButton_Click(object sender, EventArgs e)
        {
            MPAiUser user = UserManagement.CurrentUser;
            PlotController.PlotType? plotType = PlotController.PlotType.FORMANT_PLOT;
            VoiceType? voiceType = user.Voice;
            PlotController.RunPlot(plotType, voiceType);


            closeThis();
        }
    }
}
