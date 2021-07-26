using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Project_4
{
    public partial class hirex_form : Form
    {
        public hirex_form()
        {
            InitializeComponent();
        }

        private void studentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._UM_StudentsDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_UM_StudentsDataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this._UM_StudentsDataSet.Students);

        }

        private void sort_by_experience_button_Click(object sender, EventArgs e)
        {
            this.studentsTableAdapter.SortByExperience(this._UM_StudentsDataSet.Students);
        }

        private void sort_by_projects_button_Click(object sender, EventArgs e)
        {
            this.studentsTableAdapter.SortByProjects(this._UM_StudentsDataSet.Students);
        }

        private void sort_by_languages_spoken_button_Click(object sender, EventArgs e)
        {
            this.studentsTableAdapter.SortByLanguagesSpoken(this._UM_StudentsDataSet.Students);
        }

        private void sort_by_countries_traveled_button_Click(object sender, EventArgs e)
        {
            this.studentsTableAdapter.SortByCountriesTraveled(this._UM_StudentsDataSet.Students);
        }

        private void default_button_Click(object sender, EventArgs e)
        {
            this.studentsTableAdapter.Fill(this._UM_StudentsDataSet.Students);
        }

        private void search_button_for_programming_languagr_Click(object sender, EventArgs e)
        {
            this.studentsTableAdapter.SearchProgrammingLanguage(this._UM_StudentsDataSet.Students, programming_textbox.Text);
        }

        private void search_button_for_school_Click(object sender, EventArgs e)
        {
            this.studentsTableAdapter.SearchSchool(this._UM_StudentsDataSet.Students, school_textBox.Text);
        }

        private void search_button_for_major_Click(object sender, EventArgs e)
        {
            this.studentsTableAdapter.SearchMajor(this._UM_StudentsDataSet.Students, major_textbox.Text);
        }

        private void sort_by_gpa_button_Click(object sender, EventArgs e)
        {
            this.studentsTableAdapter.SortByGPA(this._UM_StudentsDataSet.Students);
        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void delete_all_items_button_Click(object sender, EventArgs e)
        {
            this.studentsTableAdapter.DeleteItems();
            this.studentsTableAdapter.Fill(this._UM_StudentsDataSet.Students);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            about_us about_me = new about_us();
            about_me.ShowDialog();
        }
    }
}