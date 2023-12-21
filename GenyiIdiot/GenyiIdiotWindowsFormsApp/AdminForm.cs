using GeniyIdiotClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenyiIdiotWindowsFormsApp
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addButton_Click(object sender, EventArgs e)
        {

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            //static void AddNewQuestion()
            //{
            //    while (true)
            //    {
            //        bool adminChoise = GetUserChoise("Хотите добавить вопрос?");

            //        if (adminChoise == true)
            //        {
            //            WriteLine("Введите вопрос: ");
            //            string question = ReadLine();
            //            Write("Введите ответ на вопрос: ");
            //            var answer = GetNumber();

            //            var newQuestion = new Question(question, answer);
            //            QuestionsStorage.Add(newQuestion);
            //            adminChoise = GetUserChoise("Хотите добавить ещё один вопрос?");
            //        }

            //        if (adminChoise == false)
            //            break;
            //    }

            //    while (true)
            //    {
            //        bool adminChoise = GetUserChoise("Хотите удалить сущесвтующий вопрос?");

            //        if (adminChoise == true)
            //        {
            //            RemoveQuestion();
            //        }
            //        if (adminChoise == false)
            //            break;
            //    }

            //}
        }
    }
}
