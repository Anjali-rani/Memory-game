using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Memorygame2
{
	public partial class GameWindow : Form
	{
		//Variables

		//int score = 0; // Our score

		Random Location = new Random();                        //Select Rndomly location for X and Y cards.
															   //List<int> X = new List<int>(); // X value for each PictureBox.
															   //List<int> Y = new List<int>(); // Y value for each PictureBox.

		List<Point> points = new List<Point>();            //List to hold card points.


		bool again = false; //Play again or no.
							// List<int> IDS = new List<int>();
							//      List<PictureBox> pictureBoxes = new List<PictureBox>();

		PictureBox PendingImage1; //store first flipped card into this variables
		PictureBox PendingImage2;  //store second flipped card into this variables


		public GameWindow()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			label2.Text = "5";
			foreach (PictureBox picture in CardHolder.Controls)
			{
				picture.Enabled = false;
				points.Add(picture.Location);


			}
			foreach (PictureBox picture in CardHolder.Controls)
			{
				int next = Location.Next(points.Count);
				Point p = points[next];
				picture.Location = p;
				points.Remove(p);


			}
			timer2.Start();
			timer1.Start();
			pictureBox1.Image = Properties.Resources.association;
			DuppictureBox1.Image = Properties.Resources.association;
			pictureBox2.Image = Properties.Resources.linkedin;
			DuppictureBox2.Image = Properties.Resources.linkedin;
			pictureBox3.Image = Properties.Resources.Googleplay;
			DuppictureBox3.Image = Properties.Resources.Googleplay;
			pictureBox4.Image = Properties.Resources.Pendrive;
			DuppictureBox4.Image = Properties.Resources.Pendrive;
			pictureBox5.Image = Properties.Resources.googleplus;
			DuppictureBox5.Image = Properties.Resources.googleplus;
			pictureBox6.Image = Properties.Resources.whatsapp;
			DuppictureBox6.Image = Properties.Resources.whatsapp;
			pictureBox7.Image = Properties.Resources.instagram;
			DuppictureBox7.Image = Properties.Resources.instagram;
			pictureBox8.Image = Properties.Resources.pinterest;
			DuppictureBox8.Image = Properties.Resources.pinterest;
			pictureBox9.Image = Properties.Resources.fb;
			DuppictureBox9.Image = Properties.Resources.fb;


			//foreach (PictureBox picture in CardHolder.Controls)
			//{
			//    picture.Image = Properties.Resources.Whatiam;

		}




		private void pictureBox2_Click(object sender, EventArgs e)
		{
			pictureBox2.Image = Properties.Resources.linkedin;

			if (PendingImage1 == null)
			{
				PendingImage1 = pictureBox2;
			}
			else if (PendingImage1 != null && PendingImage2 == null)
			{
				PendingImage2 = pictureBox2;
			}
			if (PendingImage1 != null && PendingImage2 != null)
			{
				if (PendingImage1.Tag == PendingImage2.Tag)
				{
					PendingImage1 = null;
					PendingImage2 = null;
					pictureBox2.Enabled = false;
					DuppictureBox2.Enabled = false;

					ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);

				}
				else
				{
					ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
					timer3.Start();


				}
			}

		}


		private void pictureBox1_Click(object sender, EventArgs e)
		{

			pictureBox1.Image = Properties.Resources.association;

			if (PendingImage1 == null)
			{
				PendingImage1 = pictureBox1;
			}
			else if (PendingImage1 != null && PendingImage2 == null)
			{
				PendingImage2 = pictureBox1;
			}
			if (PendingImage1 != null && PendingImage2 != null)
			{
				if (PendingImage1.Tag == PendingImage2.Tag)
				{
					PendingImage1 = null;
					PendingImage2 = null;
					pictureBox1.Enabled = false;
					DuppictureBox1.Enabled = false;
					ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);

				}
				else
				{
					ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
					timer3.Start();


				}
			}

		}

		private void DuppictureBox3_Click(object sender, EventArgs e)
		{
			DuppictureBox3.Image = Properties.Resources.Googleplay;

			if (PendingImage1 == null)
			{
				PendingImage1 = DuppictureBox3;
			}
			else if (PendingImage1 != null && PendingImage2 == null)
			{
				PendingImage2 = DuppictureBox3;
			}
			if (PendingImage1 != null && PendingImage2 != null)
			{
				if (PendingImage1.Tag == PendingImage2.Tag)
				{
					PendingImage1 = null;
					PendingImage2 = null;
					pictureBox3.Enabled = false;
					DuppictureBox3.Enabled = false;

					ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);

				}
				else
				{
					ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
					timer3.Start();


				}
			}

		}


		private void ScoreCounter_Click(object sender, EventArgs e)
		{

		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			timer1.Stop();
			foreach (PictureBox picture in CardHolder.Controls)
			{
				picture.Enabled = true;
				picture.Cursor = Cursors.Hand;
				picture.Image = Properties.Resources.Whatiam;



			}
		}

		private void timer2_Tick(object sender, EventArgs e)
		{
			int timer = Convert.ToInt32(label2.Text);
			timer = timer-1;
			label2.Text = Convert.ToString(timer);
			if (timer == 0)
			{
				timer2.Stop();
			}
		}

		private void DuppictureBox1_Click(object sender, EventArgs e)
		{
			DuppictureBox1.Image = Properties.Resources.association;

			if (PendingImage1 == null)
			{
				PendingImage1 = DuppictureBox1;
			}
			else if (PendingImage1 != null && PendingImage2 == null)
			{
				PendingImage2 = DuppictureBox1;
			}
			if (PendingImage1 != null && PendingImage2 != null)
			{
				if (PendingImage1.Tag == PendingImage2.Tag)
				{
					PendingImage1 = null;
					PendingImage2 = null;
					pictureBox1.Enabled = false;
					DuppictureBox1.Enabled = false;

					ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);

				}
				else
				{
					ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
					timer3.Start();


				}
			}

		}


		private void DuppictureBox2_Click(object sender, EventArgs e)
		{
			DuppictureBox2.Image = Properties.Resources.linkedin;



			if (PendingImage1 == null)
			{
				PendingImage1 = DuppictureBox2;
			}
			else if (PendingImage1 != null && PendingImage2 == null)
			{
				PendingImage2 = DuppictureBox2;
			}
			if (PendingImage1 != null && PendingImage2 != null)
			{
				if (PendingImage1.Tag == PendingImage2.Tag)
				{
					PendingImage1 = null;
					PendingImage2 = null;
					pictureBox2.Enabled = false;
					DuppictureBox2.Enabled = false;

					ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);

				}
				else
				{
					ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
					timer3.Start();



				}

			}
		}

		private void pictureBox3_Click_1(object sender, EventArgs e)
		{
			pictureBox3.Image = Properties.Resources.Googleplay;

			if (PendingImage1 == null)
			{
				PendingImage1 = pictureBox3;
			}
			else if (PendingImage1 != null && PendingImage2 == null)
			{
				PendingImage2 = pictureBox3;
			}
			if (PendingImage1 != null && PendingImage2 != null)
			{
				if (PendingImage1.Tag == PendingImage2.Tag)
				{
					PendingImage1 = null;
					PendingImage2 = null;
					pictureBox3.Enabled = false;
					DuppictureBox3.Enabled = false;

					ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);

				}
				else
				{
					ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
					timer3.Start();



				}

			}

		}

		private void pictureBox4_Click(object sender, EventArgs e)
		{
			pictureBox4.Image = Properties.Resources.Pendrive;

			if (PendingImage1 == null)
			{
				PendingImage1 = pictureBox4;
			}
			else if (PendingImage1 != null && PendingImage2 == null)
			{
				PendingImage2 = pictureBox4;
			}
			if (PendingImage1 != null && PendingImage2 != null)
			{
				if (PendingImage1.Tag == PendingImage2.Tag)
				{
					PendingImage1 = null;
					PendingImage2 = null;
					pictureBox4.Enabled = false;
					DuppictureBox4.Enabled = false;

					ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
				}
				else
				{
					ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
					timer3.Start();



				}

			}
		}

		private void DuppictureBox4_Click(object sender, EventArgs e)
		{
			DuppictureBox4.Image = Properties.Resources.Pendrive;

			if (PendingImage1 == null)
			{
				PendingImage1 = DuppictureBox4;
			}
			else if (PendingImage1 != null && PendingImage2 == null)
			{
				PendingImage2 = DuppictureBox4;
			}
			if (PendingImage1 != null && PendingImage2 != null)
			{
				if (PendingImage1.Tag == PendingImage2.Tag)
				{
					PendingImage1 = null;
					PendingImage2 = null;
					pictureBox4.Enabled = false;
					DuppictureBox4.Enabled = false;

					ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
				}
				else
				{
					ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
					timer3.Start();


				}
			}

		}


		private void pictureBox5_Click(object sender, EventArgs e)
		{
			pictureBox5.Image = Properties.Resources.googleplus;

			if (PendingImage1 == null)
			{
				PendingImage1 = pictureBox5;
			}
			else if (PendingImage1 != null && PendingImage2 == null)
			{
				PendingImage2 = pictureBox5;
			}
			if (PendingImage1 != null && PendingImage2 != null)
			{
				if (PendingImage1.Tag == PendingImage2.Tag)
				{
					PendingImage1 = null;
					PendingImage2 = null;
					pictureBox5.Enabled = false;
					DuppictureBox5.Enabled = false;

					ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
				}
				else
				{
					ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
					timer3.Start();


				}
			}

		}



		private void DuppictureBox5_Click(object sender, EventArgs e)

		{
			DuppictureBox5.Image = Properties.Resources.googleplus;

			if (PendingImage1 == null)
			{
				PendingImage1 = DuppictureBox5;
			}
			else if (PendingImage1 != null && PendingImage2 == null)
			{
				PendingImage2 = DuppictureBox5;
			}
			if (PendingImage1 != null && PendingImage2 != null)
			{
				if (PendingImage1.Tag == PendingImage2.Tag)
				{
					PendingImage1 = null;
					PendingImage2 = null;
					pictureBox5.Enabled = false;
					DuppictureBox5.Enabled = false;
					ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
				}
				else
				{
					ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
					timer3.Start();


				}


			}
		}

		private void pictureBox6_Click_1(object sender, EventArgs e)
		{
			pictureBox6.Image = Properties.Resources.whatsapp;

			if (PendingImage1 == null)
			{
				PendingImage1 = pictureBox6;
			}
			else if (PendingImage1 != null && PendingImage2 == null)
			{
				PendingImage2 = pictureBox6;
			}
			if (PendingImage1 != null && PendingImage2 != null)
			{
				if (PendingImage1.Tag == PendingImage2.Tag)
				{
					PendingImage1 = null;
					PendingImage2 = null;
					pictureBox6.Enabled = false;
					DuppictureBox6.Enabled = false;

					ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
				}
				else
				{
					ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
					timer3.Start();


				}
			}

		}



		private void DuppictureBox6_Click(object sender, EventArgs e)
		{
			DuppictureBox6.Image = Properties.Resources.whatsapp;

			if (PendingImage1 == null)
			{
				PendingImage1 = DuppictureBox6;
			}
			else if (PendingImage1 != null && PendingImage2 == null)
			{
				PendingImage2 = DuppictureBox6;
			}
			if (PendingImage1 != null && PendingImage2 != null)
			{
				if (PendingImage1.Tag == PendingImage2.Tag)
				{
					PendingImage1 = null;
					PendingImage2 = null;
					pictureBox6.Enabled = false;
					DuppictureBox6.Enabled = false;

					ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);

				}
				else
				{
					ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
					timer3.Start();


				}
			}


		}

		private void pictureBox7_Click(object sender, EventArgs e)
		{
			pictureBox7.Image = Properties.Resources.instagram;

			if (PendingImage1 == null)
			{
				PendingImage1 = pictureBox7;
			}
			else if (PendingImage1 != null && PendingImage2 == null)
			{
				PendingImage2 = pictureBox7;
			}
			if (PendingImage1 != null && PendingImage2 != null)
			{
				if (PendingImage1.Tag == PendingImage2.Tag)
				{
					PendingImage1 = null;
					PendingImage2 = null;
					pictureBox7.Enabled = false;
					DuppictureBox7.Enabled = false;

					ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
				}
				else
				{
					ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
					timer3.Start();


				}
			}

		}


		private void DuppictureBox7_Click(object sender, EventArgs e)
		{
			DuppictureBox7.Image = Properties.Resources.instagram;

			if (PendingImage1 == null)
			{
				PendingImage1 = DuppictureBox7;
			}
			else if (PendingImage1 != null && PendingImage2 == null)
			{
				PendingImage2 = DuppictureBox7;
			}
			if (PendingImage1 != null && PendingImage2 != null)
			{
				if (PendingImage1.Tag == PendingImage2.Tag)
				{
					PendingImage1 = null;
					PendingImage2 = null;
					pictureBox7.Enabled = false;
					DuppictureBox7.Enabled = false;

					ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
				}
				else
				{
					ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
					timer3.Start();


				}
			}

		}



		private void DuppictureBox8_Click(object sender, EventArgs e)
		{
			DuppictureBox8.Image = Properties.Resources.pinterest;

			if (PendingImage1 == null)
			{
				PendingImage1 = DuppictureBox8;
			}
			else if (PendingImage1 != null && PendingImage2 == null)
			{
				PendingImage2 = DuppictureBox8;
			}
			if (PendingImage1 != null && PendingImage2 != null)
			{
				if (PendingImage1.Tag == PendingImage2.Tag)
				{
					PendingImage1 = null;
					PendingImage2 = null;
					pictureBox8.Enabled = false;
					DuppictureBox8.Enabled = false;

					ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
				}
				else
				{
					ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
					timer3.Start();


				}
			}

		}


		private void pictureBox9_Click(object sender, EventArgs e)
		{
			pictureBox9.Image = Properties.Resources.fb;
			if (PendingImage1 == null)
			{
				PendingImage1 = pictureBox9;
			}
			else if (PendingImage1 != null && PendingImage2 == null)
			{
				PendingImage2 = pictureBox9;
			}
			if (PendingImage1 != null && PendingImage2 != null)
			{
				if (PendingImage1.Tag == PendingImage2.Tag)
				{
					PendingImage1 = null;
					PendingImage2 = null;
					pictureBox9.Enabled = false;
					DuppictureBox9.Enabled = false;

					ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);

				}
				else
				{
					ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
					timer3.Start();


				}
			}

		}



		private void pictureBox8_Click(object sender, EventArgs e)
		{
			pictureBox8.Image = Properties.Resources.pinterest;

			if (PendingImage1 == null)
			{
				PendingImage1 = pictureBox8;
			}
			else if (PendingImage1 != null && PendingImage2 == null)
			{
				PendingImage2 = pictureBox8;
			}
			if (PendingImage1 != null && PendingImage2 != null)
			{
				if (PendingImage1.Tag == PendingImage2.Tag)
				{
					PendingImage1 = null;
					PendingImage2 = null;
					pictureBox8.Enabled = false;
					DuppictureBox8.Enabled = false;

					ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
				}
				else
				{
					
					timer3.Start();


				}
			}


		}

		private void DuppictureBox9_Click(object sender, EventArgs e)
		{
			DuppictureBox9.Image = Properties.Resources.fb;

			if (PendingImage1 == null)
			{
				PendingImage1 = DuppictureBox9;
			}
			else if (PendingImage1 != null && PendingImage2 == null)
			{
				PendingImage2 = DuppictureBox9;
			}
			if (PendingImage1 != null && PendingImage2 != null)
			{
				if (PendingImage1.Tag == PendingImage2.Tag)
				{
					PendingImage1 = null;
					PendingImage2 = null;
					pictureBox9.Enabled = false;
					DuppictureBox9.Enabled = false;

				}
				else
				{

					timer3.Start();


			


		}
	}
    }

       

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
           
            PendingImage1.Image = Properties.Resources.Whatiam;
            PendingImage2.Image = Properties.Resources.Whatiam;
            PendingImage1 = null;
            PendingImage2 = null;
        }

		private void button1_Click(object sender, EventArgs e)
		{
		
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
				Form1_Load(sender,e);
			ScoreCounter.Enabled = false;

		}
	}
}
