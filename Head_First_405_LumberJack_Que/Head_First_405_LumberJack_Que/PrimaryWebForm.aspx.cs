using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text; 

namespace Head_First_405_LumberJack_Que
{
  public partial class PrimaryWebForm : System.Web.UI.Page
  {
    private static Queue<Lumberjack> breakfastLine = new Queue<Lumberjack>();

    
    private void RedrawList()
    {
      int number = 1;
      Line.Items.Clear();
      foreach (Lumberjack lumberJackCycle in breakfastLine)
      {
        Line.Items.Add(number + "." + lumberJackCycle.Name);
        number++;
      }
     
      if (breakfastLine.Count == 0)
      {
        CrispyRadioButton1.Enabled = false;
        SoggyRadioButton1.Enabled = false;
        BrownedRadioButton1.Enabled = false;
        BananaRadioButton2.Enabled = false;
        nextInLine.Text = ""; 
      }
      else
      {
        CrispyRadioButton1.Enabled =true;
        SoggyRadioButton1.Enabled = true;
        BrownedRadioButton1.Enabled = true;
        BananaRadioButton2.Enabled = true;
        Lumberjack currentLumberjack = breakfastLine.Peek();
        nextInLine.Text = currentLumberjack.Name + " has "
        + currentLumberjack.FlapjackCount + " flapjacks";
      }
    }
    //The EatFlapjacks method uses a while loop to print out the lumberjack’s meal.

    public enum Flapjack
    {
      Crispy,
      Soggy,
      Browned,
      Banana,
    }
    class Lumberjack
    {
      
      private string name;
      public string Name
      {
        get { return name; }
        set { name = value; }
      }

      private Stack<Flapjack> meal;

      // Constructor
      public Lumberjack(string name)
      {
        this.name = name;
        meal = new Stack<Flapjack>();
      }


      public int FlapjackCount
      {
        get { return meal.Count; }
        set { }
      }

      public void TakeFlapjacks(Flapjack cookedHow, int howMany)
      {
        for (int i = 0; i < howMany; i++)
        {
          meal.Push(cookedHow);
        }
      }

      public string EatFlapjacks()
      {
        return (name + "’s eating flapjacks");
      }

      public List<string> EatFlapjacks2()
      {
        List<String> listOfFlapJackStrings = new List<string>(); 
        foreach (Flapjack flapInstance in meal)
        {
          listOfFlapJackStrings.Add(name + " ate a "+ flapInstance.ToString().ToLower() + " flapjack, ");
        }
         return listOfFlapJackStrings; 
          
      }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
    
    }

    protected void NextLumberJackButton_Click(object sender, EventArgs e)
    {
      if (breakfastLine.Count == 0) return;
      Lumberjack nextLumberjack = breakfastLine.Dequeue();
      OutputListBox.Items.Add(nextLumberjack.EatFlapjacks());
      foreach(string strings in nextLumberjack.EatFlapjacks2())
      {
      OutputListBox.Items.Add(strings);
      }

      nextInLine.Text = "";
      RedrawList();
    }

    protected void AddLumberJackButton_Click(object sender, EventArgs e)
    {
      if (String.IsNullOrEmpty(TextBox1.Text)) return;
      breakfastLine.Enqueue(new Lumberjack(TextBox1.Text));
      TextBox1.Text = "";
      RedrawList(); 
      if(breakfastLine.Count <= 0)
      {
        // do somthing
      }
    }

    protected void Addflapjacks_Click(object sender, EventArgs e)
    {

      if (PanCakeNumBox1.Text == "") return; 

      if (breakfastLine.Count == 0) return;
      Flapjack food;
      if (CrispyRadioButton1.Checked == true)
      {
        food = Flapjack.Crispy;
      }
      else if (SoggyRadioButton1.Checked == true)
      {
        food = Flapjack.Soggy;
      }
      else if (BrownedRadioButton1.Checked == true)
      {
        food = Flapjack.Soggy;
      }
      else
      {
        food = Flapjack.Banana;
      }

      Lumberjack currentlumberjack = breakfastLine.Peek();
      int numOfPankakes = Int32.Parse(PanCakeNumBox1.Text);
      currentlumberjack.TakeFlapjacks(food, numOfPankakes);
      RedrawList(); 
    }
  }
}