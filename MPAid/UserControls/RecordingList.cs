﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using MPAid.Models;
using MPAid.Cores;

namespace MPAid.UserControls
{
    public partial class RecordingList : UserControl
    {
        public ComboBox SpeakerComboBox
        {
            get { return speakerComboBox; }
        }
        public ComboBox CategoryComboBox
        {
            get { return categoryComboBox; }
        }
        public ListBox WordListBox
        {
            get { return wordListBox; }
        }
        public RecordingList()
        {
            InitializeComponent();
        }

        public void DataBinding()
        {
            //this.speakerComboBox.DataSource = MainForm.self.DBModel.Speaker.Local.ToBindingList();
            this.speakerComboBox.DataSource = MainForm.self.DBModel.Speaker.Local.ToBindingList();
            this.speakerComboBox.DisplayMember = "Name";
            //this.speakerComboBox.SelectedIndex = 0;

            this.categoryComboBox.DataSource = MainForm.self.DBModel.Category.Local.ToBindingList();
            this.categoryComboBox.DisplayMember = "Name";
            //this.categoryComboBox.SelectedIndex = 0;
        }

        private void SpeakerOrCategoryComboBox_OnSelectedValueChanged(object sender, EventArgs e)
        {
            Speaker spk = speakerComboBox.SelectedItem as Speaker;
            Category cty = categoryComboBox.SelectedItem as Category;
            if(spk == null || cty == null)
            {
                this.wordListBox.DataSource = null;
                return;
            }

            List<Word> view = MainForm.self.DBModel.Word.Where(
                x => (x.CategoryId == cty.CategoryId &&
                    x.Recordings.Any(y => y.SpeakerId == spk.SpeakerId))
                ).ToList();

            view.Sort(new VowelComparer());
            this.wordListBox.DataSource = new BindingSource() { DataSource = view};
            this.wordListBox.DisplayMember = "Name";
        }

    }
}