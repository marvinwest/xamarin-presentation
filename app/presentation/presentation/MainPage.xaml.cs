using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace presentation
{
    public partial class MainPage : ContentPage
    {

        private static String[] sentences =
        {
            "Hello Marvin!",
            "Hello Tabea!",
            "Hello Piush!"
        };

        String sentence;

        public MainPage()
        {
            RandomizeSentence();
            BindingContext = this;
            InitializeComponent();
        }

        void Shuffle_OnClicked(object sender, EventArgs e)
        {
            RandomizeSentence();
        }

        public String Sentence
        {
            get { return sentence;  }
            set
            {
                sentence = value;
                OnPropertyChanged("Sentence");
            }
        }

        private void RandomizeSentence()
        {
            Random rand = new Random();
            int index = rand.Next(sentences.Length);
            Sentence = sentences[index];
        }
    }
}
