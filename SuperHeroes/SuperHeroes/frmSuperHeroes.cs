using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

/*
 *      LB1 SuperHeroDatabase
 *      
 *      Create a GUI application to look up 
 *      information about superheroes.
 *      
 *      1.	Program must contain information 
 *          about at least 5 superheroes.
 *          
 *      2.	Dropdown must be populated 
 *          programmatically.
 *          
 *      3.  When the user selects an option from 
 *          the dropdown, display all available 
 *          information about that superhero.
 */

namespace SuperHeroes
{
    public partial class frmSuperHeroes : Form
    {
        public frmSuperHeroes()
        {
            InitializeComponent();
        }

        //  Global Arrays
        string[] superHeroNames = {
            "Marvel SuperHeroes",
            "Captain America",
            "The Incredible Hulk",
            "The Invincible Iron Man",
            "The Mighty Thor",
            "The Sub-Mariner"
        };

        string[] superHeroAlterEgo = {
            "Not Applicable",
            "Steve Rogers",
            "Bruce Banner",
            "Tony Stark",
            "Thor Odinson",
            "Prince Namor"
        };

        string[] superHeroImages = {
            @"C:\Users\jpscott\Desktop\Ch9-11Homework\Homework9-11\SuperHeroes\images\00-all.png",
            @"C:\Users\jpscott\Desktop\Ch9-11Homework\Homework9-11\SuperHeroes\images\01-captainamerica.png",
            @"C:\Users\jpscott\Desktop\Ch9-11Homework\Homework9-11\SuperHeroes\images\02-hulk.png",
            @"C:\Users\jpscott\Desktop\Ch9-11Homework\Homework9-11\SuperHeroes\images\03-ironman.png",
            @"C:\Users\jpscott\Desktop\Ch9-11Homework\Homework9-11\SuperHeroes\images\04-thor.png",
            @"C:\Users\jpscott\Desktop\Ch9-11Homework\Homework9-11\SuperHeroes\images\05-submariner.png"
        };

        string[] superHeroBio = {
            "The Marvel Super Heroes is an American animated television series starring five comic book superheroes from Marvel Comics. The first TV series based on Marvel characters, it debuted in syndication on U.S. television in 1966. The segments were Captain America, The Incredible Hulk, Iron Man, The Mighty Thor and The Sub-Mariner.",
            "Captain America was designed as a patriotic supersoldier who often fought the Axis powers of World War II. Captain America is the alter ego of Steve Rogers, a frail young artist enhanced to the peak of human perfection by an experimental super-soldier serum after joining the military to aid the United States government's efforts in World War II.",
            "The Hulk is a green-skinned, hulking and muscular humanoid possessing a limitless degree of physical strength, and his alter ego Dr. Robert Bruce Banner, a physically weak, socially withdrawn, and emotionally reserved physicist. The two exist as independent dissociative personalities, and resent each other, following Banner's accidental exposure to gamma rays.",
            "Iron Man is a superhero appearing in comic books published by Marvel Comics. Wealthy business magnate, playboy, philanthropist, inventor and scientist Anthony Edward Stark suffers a severe chest injury during a kidnapping. When his captors attempt to force him to build a weapon of mass destruction, he instead creates a mechanized suit.",
            "Thor Odinson, or simply Thor, is a fictional character appearing in American comic books published by Marvel Comics. The character is based on the Norse deity of the same name, the Asgardian god of thunder whose enchanted hammer Mjolnir enables him to fly and manipulate weather.",
            "Namor McKenzie, also known as the Sub-Mariner, is a fictional character appearing in American comic books published by Marvel Comics. The mutant son of a human sea captain and a princess of the mythical undersea kingdom of Atlantis, Namor possesses the super-strength and aquatic abilities ."
        };

        string[] superHeroURL = {
            "https://en.wikipedia.org/wiki/The_Marvel_Super_Heroes",
            "https://en.wikipedia.org/wiki/Captain_America",
            "https://en.wikipedia.org/wiki/Hulk",
            "https://en.wikipedia.org/wiki/Iron_Man",
            "https://en.wikipedia.org/wiki/Thor_(Marvel_Comics)",
            "https://en.wikipedia.org/wiki/Namor"
        };

        private void frmSuperHeroes_Load_1(object sender, EventArgs e)
        {
            //  Filling up the combo box.
            for (int lcv = 0; lcv < superHeroNames.Length; lcv++)
            {
                cboSuperHero.Items.Add(superHeroNames[lcv]);
            }

            ClearAll();
        }

        private void cboSuperHero_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowCorrectSuperHero();
        }

        private void ShowCorrectSuperHero()
        {
            int si = cboSuperHero.SelectedIndex;

            switch (si)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    CreateSuperHero(si);
                    break;

                default:
                    break;
            }
        }

        private void CreateSuperHero(int si)
        {
            pbSuperHeroImage.Image = System.Drawing.Image.FromFile(superHeroImages[si]);
            lblName.Text = "Name: " + superHeroNames[si];
            lblAlterEgo.Text = "Alter Ego: " + superHeroAlterEgo[si];
            lblBio.Text = "Bio:  " + superHeroBio[si];
            lblURL.Text = "URL:  " + superHeroURL[si];
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            cboSuperHero.SelectedIndex = 0;
            lblName.Text = "Name: " + superHeroNames[0];
            lblBio.Text = "Bio:  " + superHeroBio[0];
            lblURL.Text = "URL:   " + superHeroURL[0];
            pbSuperHeroImage.Image = System.Drawing.Image.FromFile(superHeroImages[0]);
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitProgramOrNot();
        }

        private void ExitProgramOrNot()
        {
            DialogResult dialog = MessageBox.Show(
                   "Do You Really Want To Exit?",
                   "EXIT NOW?",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}