using System;
using System.Drawing;
using System.Windows.Forms;
public class UiFile:Form{
  //add controls==================================================================
      //color add controls
  private Button rfirst = new Button();
  private Button gsecond = new Button();
  private Button bthird = new Button();
      //size add controls
  private Button smallsize = new Button();
  private Button mediumsize = new Button();
  private Button bigsize = new Button();

  private Button enterbutton = new Button();
  private Button clearbutton = new Button();
  private Button exitbutton = new Button();

  Color color200 = Color.Pink;
  Color color400 = Color.Pink;
  Color color600 = Color.Pink;
  Color c        = Color.Pink;
  int radius    = 200;



  // private Color c = Color.Yellow();     //default color
// end of add controls ===========================================================

public UiFile(){
  //set the captions for the buttons==============================================\

        /*TURN COLOR BACK ON AFTER DONE WITH PROGRAMMING AND PUTTING CIRCLES
        IN THE RIGHT PLACE*/

  //BackColor = Color.Pink;


  //FillRectangle = (brush.Orchid, 0, 355,900,700);

  Text = "Assignment 1: Drawing Circles";

  rfirst.Text = "Red";
  gsecond.Text = "Green";
  bthird.Text = "Blue";

  smallsize.Text = "200 px";
  mediumsize.Text = "400 px";
  bigsize.Text = "600 px";

  enterbutton.Text = "Enter";
  clearbutton.Text = "Clear";
  exitbutton.Text = "Exit";
  //end of text captions =========================================================

  //select the size of the Window=================================================
  Size = new Size(1000,900);
  //end of Window size ===========================================================

  //set location of buttons ======================================================
  int b =675;
  rfirst.Location = new Point (50, b);
  gsecond.Location = new Point (50, b += 5 + rfirst.Height);
  bthird.Location = new Point (50, b += 5 + gsecond.Height); //385 + rfirst.Height + 5);

  int q = 675;
  smallsize.Location = new Point(60+ rfirst.Width +10, q);
  mediumsize.Location = new Point (60+ gsecond.Width+10, q += 5 + mediumsize.Height);
  bigsize.Location = new Point (60+bthird.Width+10, q+= 5 + mediumsize.Height);

  int z = 675;
  enterbutton.Location = new Point (150 + smallsize.Width + 20, z);
  clearbutton.Location = new Point(150 + mediumsize.Width + 20, z += 5 + enterbutton.Height);
  exitbutton.Location = new Point (150 + bigsize.Width+ 20, z += 5 + clearbutton.Height);


  //FillRectangle = (brush.Pink, 0, 375, 1000,900 );


  //add controls to the Form
  Controls.Add(rfirst);
  Controls.Add(gsecond);
  Controls.Add(bthird);
  Controls.Add(smallsize);
  Controls.Add(mediumsize);
  Controls.Add(bigsize);
  Controls.Add(enterbutton);
  Controls.Add(clearbutton);
  Controls.Add(exitbutton);
  //end of add controls to the form

  //EventHandler
  gsecond.Click += new EventHandler(Greenclick);
  rfirst.Click += new EventHandler(RedClick);
  bthird.Click += new EventHandler(BlueClick);

  smallsize.Click += new EventHandler(smallClick);
  mediumsize.Click += new EventHandler(mediumClick);
  bigsize.Click += new EventHandler(largeClick);

  exitbutton.Click += new EventHandler(exitClick);
  //need to do
  enterbutton.Click += new EventHandler(DrawFunction);
  clearbutton.Click += new EventHandler(clearClick);

}//end of UiFile

//set buttons for radius size
protected void smallClick(Object sender, EventArgs e){radius = 200;}
protected void mediumClick(Object sender, EventArgs e){radius = 400;}
protected void largeClick(Object sender, EventArgs e){radius = 600;}

//set buttons for color
protected void Greenclick(Object sender, EventArgs e){c=Color.Green;}
protected void BlueClick(Object sender, EventArgs e){c=Color.Blue;}
protected void RedClick(Object sender, EventArgs e){c= Color.Red;}




protected void DrawFunction(Object sender, EventArgs e){   //dummy parameters
    switch(radius)
    {
      case 200:
        color200=c;
        break;
      case 600:
        color600=c;
        break;
      case 400:
        color400=c;
        break;
    }
    Invalidate(); //this calls the OnPaint function.
  }
  protected override void OnPaint(PaintEventArgs anything){
    Graphics area = anything.Graphics;
      //makes a copy of the class Graphics
    Pen pen = new Pen(Brushes.Pink,3);
    pen.Color = color200;   //this gives us something to write with
    area.DrawEllipse(pen, 5,450, 2*200, 2*200); //we're doubling to make the diameter
    pen.Color = color400;
    area.DrawEllipse(pen, 500,450, 2*400, 2*400);
    pen.Color = color600;
    area.DrawEllipse(pen, 500,450, 2*600, 2*600);

    // Create solid brush.
    SolidBrush blueBrush = new SolidBrush(Color.SkyBlue);

    // Create rectangle.
    Rectangle rect = new Rectangle(0, 660, 1000, 900);

    // Fill rectangle to screen.
    anything.Graphics.FillRectangle(blueBrush, rect);
    //area.FillRectangle(pen, 0,360,1000,900);
    base.OnPaint(anything);
  }

  protected void exitClick(Object sender, EventArgs e){
    System.Console.WriteLine("This program will end execution.");
        Close();
  }

  protected void clearClick(Object sender, EventArgs e){
    switch(radius){
      case 200:
        color200=Color.Pink;
        break;
      case 400:
        color400=Color.Pink;
        break;
      case 600:
        color600 = Color.Pink;
        break;
    }
    Invalidate();
  }


}//end of UiFile form


// public class CircleAlgorithms{
//   public status System.Drawing.Rectangle
//   getcircleinfo(int graphareawidth, int graphareaheight, int radius){
//    Point corner = new Point(graphareawidth/2 -radius, graphicalareaheight/2 - radius);  //the concept is we find the center of the graphical area of our field.
//    Size lenwide = new Size(2*radius, 2* radius);
//    Rectangle rect = new Rectangle(corner, lenwide);
//    // return rect;
//   } //end of function
//}//end of class
