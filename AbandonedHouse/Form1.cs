using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbandonedHouse
{
    public partial class Form1 : Form
    {
        bool sceneOneOut;
        bool scene17Out;
        Random random = new Random();
        //byte randomStore;
        byte scene = 0;
        bool hasPoison = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.M) //red button press
            {
                switch (scene)
                {
                    case 0:
                        scene = 3;
                        break;
                    case 1:
                        if (random.Next(1, 100) >= 70)
                        {
                            scene = 0;
                            sceneOneOut = true;
                        }
                        else
                        {
                            scene = 99;
                            sceneOneOut = false;
                        }
                        break;
                    case 2:
                        scene = 24;
                        break;
                    case 3:
                        scene = 4;
                        break;
                    case 4:
                        scene = 6;
                        break;
                    case 5:
                        scene = 99;
                        break;
                    case 6:
                        scene = 8;
                        break;
                    case 7:
                        scene = 99;
                        break;
                    case 8:
                        scene = 9;
                        break;
                    case 9:
                        scene = 10;
                        break;
                    case 10:
                        scene = 11;
                        break;
                    case 11:
                        scene = 99;
                        break;
                    case 12:
                        scene = 13;
                        hasPoison = true;
                        break;
                    case 13:
                        scene = 14;
                        break;
                    case 14:
                        scene = 17;
                        break;
                    case 15:
                        if (hasPoison == false)
                        {
                            scene = 99;
                        }
                        else
                        {
                            scene = 22;
                        }
                        break;
                    case 16:
                        scene = 99;
                        break;
                    case 17:
                        if (random.Next(1, 100) <= 60)
                        {
                            scene17Out = false;
                            scene = 99;
                        }
                        else
                        {
                            scene17Out = true;
                            scene = 19;
                        }
                        break;
                    case 18:
                        scene = 99;
                        break;
                    case 19:
                        if (hasPoison == true)
                        {
                            scene = 20;
                        }
                        else
                        {
                            scene = 99;
                        }
                        break;
                    case 20:
                        scene = 99;
                        break;
                    case 21:
                        scene = 99;
                        break;
                    case 22:
                        scene = 99;
                        break;
                    case 23:
                        scene = 9;
                        break;
                    case 24:
                        scene = 99;
                        break;
                    case 25:
                        scene = 26;
                        break;
                    case 26:
                        scene = 99;
                        break;
                    case 27:
                        scene = 30;
                        break;
                    case 28:
                        scene = 99;
                        break;
                    case 29:
                        scene = 33;
                        break;
                    case 30:
                        scene = 33;
                        break;
                    case 31:
                        scene = 99;
                        break;
                    case 32:
                        scene = 99;
                        break;
                    case 33:
                        scene = 99;
                        break;
                    case 34:
                        scene = 99;
                        break;
                    case 35:
                        scene = 99;
                        break;
                    case 99:
                        scene = 0;
                        break;
                }
            }
            else if (e.KeyCode == Keys.B) //blue button press
            {
                switch (scene)
                {
                    case 0:
                        scene = 34;
                        break;
                    case 1:
                        if (random.Next(1, 100) >= 70)
                        {
                            scene = 0;
                            sceneOneOut = true;
                        }
                        else
                        {
                            scene = 99;
                            sceneOneOut = false;
                        }
                        break;
                    case 2:
                        scene = 25;
                        break;
                    case 3:
                        scene = 23;
                        break;
                    case 4:
                        scene = 5;
                        break;
                    case 5:
                        scene = 99;
                        break;
                    case 6:
                        scene = 7;
                        break;
                    case 7:
                        scene = 99;
                        break;
                    case 8:
                        scene = 14;
                        break;
                    case 9:
                        scene = 35;
                        break;
                    case 10:
                        scene = 12;
                        break;
                    case 11:
                        scene = 99;
                        break;
                    case 12:
                        scene = 13;
                        hasPoison = false;
                        break;
                    case 13:
                        if (hasPoison == true)
                        {
                            scene = 22;
                        }
                        else
                        {
                            scene = 14;
                        }
                        break;
                    case 14:
                        scene = 15;
                        break;
                    case 15:
                        if (hasPoison == true)
                        {
                            scene = 16;
                        }
                        else
                        {
                            scene = 99;
                        }
                        break;
                    case 16:
                        scene = 99;
                        break;
                    case 17:
                        if (random.Next(1, 100) <= 60)
                        {
                            scene17Out = false;
                            scene = 99;
                        }
                        else
                        {
                            scene17Out = true;
                            scene = 18;
                        }
                        break;
                    case 18:
                        scene = 99;
                        break;
                    case 19:
                        if (hasPoison == true)
                        {
                            scene = 20;
                        }
                        else
                        {
                            scene = 99;
                        }
                        break;
                    case 20:
                        scene = 99;
                        break;
                    case 21:
                        scene = 99;
                        break;
                    case 22:
                        scene = 99;
                        break;
                    case 23:
                        scene = 14;
                        break;
                    case 24:
                        scene = 99;
                        break;
                    case 25:
                        scene = 27;
                        break;
                    case 26:
                        scene = 99;
                        break;
                    case 27:
                        scene = 28;
                        break;
                    case 28:
                        scene = 99;
                        break;
                    case 29:
                        scene = 31;
                        break;
                    case 30:
                        scene = 31;
                        break;
                    case 31:
                        scene = 99;
                        break;
                    case 32:
                        scene = 99;
                        break;
                    case 33:
                        scene = 99;
                        break;
                    case 34:
                        scene = 99;
                        break;
                    case 35:
                        scene = 99;
                        break;
                    case 99:
                        break;
                }
            }
            else if (e.KeyCode == Keys.Space) //green button press
            {
                switch (scene)
                {
                    case 0:
                        scene = 2;
                        break;
                    case 1:
                        if (random.Next(1, 100) >= 70)
                        {
                            scene = 0;
                            sceneOneOut = true;
                        }
                        else
                        {
                            scene = 99;
                            sceneOneOut = false;
                        }
                        break;
                    case 5:
                        scene = 99;
                        break;
                    case 7:
                        scene = 99;
                        break;
                    case 11:
                        scene = 99;
                        break;
                    case 13:
                        if (hasPoison == true)
                        {
                            scene = 22;
                        }
                        else
                        {
                            scene = 14;
                        }
                        break;
                    case 14:
                        scene = 21;
                        break;
                    case 15:
                        if (hasPoison == true)
                        {
                            scene = 16;
                        }
                        else
                        {
                            scene = 99;
                        }
                        break;
                    case 16:
                        scene = 99;
                        break;
                    case 17:
                        if (random.Next(1, 100) <= 60)
                        {
                            scene17Out = false;
                            scene = 99;
                        }
                        else
                        {
                            scene17Out = true;
                            scene = 18;
                        }
                        break;
                    case 18:
                        scene = 99;
                        break;
                    case 19:
                        if (hasPoison == true)
                        {
                            scene = 20;
                        }
                        else
                        {
                            scene = 99;
                        }
                        break;
                    case 20:
                        scene = 99;
                        break;
                    case 21:
                        scene = 99;
                        break;
                    case 22:
                        scene = 99;
                        break;
                    case 24:
                        scene = 99;
                        break;
                    case 25:
                        scene = 29;
                        break;
                    case 26:
                        scene = 99;
                        break;
                    case 28:
                        scene = 99;
                        break;
                    case 29:
                        scene = 32;
                        break;
                    case 30:
                        scene = 32;
                        break;
                    case 31:
                        scene = 99;
                        break;
                    case 32:
                        scene = 99;
                        break;
                    case 33:
                        scene = 99;
                        break;
                    case 34:
                        scene = 99;
                        break;
                    case 35:
                        scene = 99;
                        break;
                    case 99:
                        break;
                }
            }
            else if (e.KeyCode == Keys.N) //yellow button press
            {
                switch (scene)
                {
                    case 0:
                        scene = 1;
                        break;
                    case 1:
                        if (random.Next(1, 100) >= 70)
                        {
                            scene = 0;
                            sceneOneOut = true;
                        }
                        else
                        {
                            scene = 99;
                            sceneOneOut = false;
                        }
                        break;
                    case 5:
                        scene = 99;
                        break;
                    case 7:
                        scene = 99;
                        break;
                    case 11:
                        scene = 99;
                        break;
                    case 13:
                        if (hasPoison == true)
                        {
                            scene = 22;
                        }
                        else
                        {
                            scene = 14;
                        }
                        break;
                    case 14:
                        scene = 21;
                        break;
                    case 15:
                        if (hasPoison == true)
                        {
                            scene = 16;
                        }
                        else
                        {
                            scene = 99;
                        }
                        break;
                    case 16:
                        scene = 99;
                        break;
                    case 17:
                        if (random.Next(1, 100) <= 60)
                        {
                            scene17Out = false;
                            scene = 99;
                        }
                        else
                        {
                            scene17Out = true;
                            scene = 18;
                        }
                        break;
                    case 18:
                        scene = 99;
                        break;
                    case 19:
                        if (hasPoison == true)
                        {
                            scene = 20;
                        }
                        else
                        {
                            scene = 99;
                        }
                        break;
                    case 20:
                        scene = 99;
                        break;
                    case 21:
                        scene = 99;
                        break;
                    case 22:
                        scene = 99;
                        break;
                    case 24:
                        scene = 99;
                        break;
                    case 25:
                        scene = 29;
                        break;
                    case 26:
                        scene = 99;
                        break;
                    case 28:
                        scene = 99;
                        break;
                    case 29:
                        scene = 32;
                        break;
                    case 30:
                        scene = 32;
                        break;
                    case 31:
                        scene = 99;
                        break;
                    case 32:
                        scene = 99;
                        break;
                    case 33:
                        scene = 99;
                        break;
                    case 34:
                        scene = 99;
                        break;
                    case 35:
                        scene = 99;
                        break;
                    case 99:
                        break;
                }
            }

            switch (scene)
            {
                case 0:
                    outputLabel.Text = "You are at the door to an abandoned house. There is a window to your left. You feel a radiant energy.";
                    redTextLabel.Text = "Enter the door";
                    blueTextLabel.Text = "Jump through the window";
                    greenTextLabel.Text = "Look for a back door";
                    yellowTextLabel.Text = "Leave";
                    break;
                case 1:
                    if (sceneOneOut == true)
                    {
                        outputLabel.Text = "You feel compelled to stay.";
                    }
                    else
                    {
                        outputLabel.Text = "You leave the area.";
                    }
                    redTextLabel.Text = "Continue";
                    blueTextLabel.Text = "Continue";
                    greenButtonLabel.Text = "Continue";
                    yellowButtonLabel.Text = "Continue";
                    break;
                case 2:
                    outputLabel.Text = "As you go to the back of the house, you admire how ancient the architecture is. You find a petrified wooden door that would likely give splinters if you opened it. You also see an open window that feels very inviting.";
                    redTextLabel.Text = "Use the door.";
                    blueTextLabel.Text = "Go into the window.";
                    greenTextLabel.Text = "";
                    yellowTextLabel.Text = "";
                    break;
                case 3:
                    outputLabel.Text = "You walk in. The door slams behind you. You see a door to your right, and a dimly lit hall to your right.";
                    redTextLabel.Text = "Open the door.";
                    blueTextLabel.Text = "Enter the hallway.";
                    greenTextLabel.Text = "";
                    yellowTextLabel.Text = "";
                    break;
                case 4:
                    outputLabel.Text = "You open the door and see an empty room with only a window, a door, and a vase. You hear a faint crying from behind the door. It sounds familiar.";
                    redTextLabel.Text = "Open the door.";
                    blueTextLabel.Text = "Use the vase.";
                    greenTextLabel.Text = "";
                    yellowTextLabel.Text = "";
                    break;
                case 5:
                    outputLabel.Text = "You pick up the vase, finding it to be heavier than you anticipated. You chuck it at the window, and watch it recoil off. It hits you in the head, killing you. The house did not like that.";
                    redTextLabel.Text = "Continue";
                    blueTextLabel.Text = "Continue";
                    greenButtonLabel.Text = "Continue";
                    yellowButtonLabel.Text = "Continue";
                    break;
                case 6:
                    outputLabel.Text = "As you open the door, you see a bloody, mutilated arm on the ground. As you look up, you see a reflection of yourself, only missing an arm. It whispers to you, 'Leave.' You spot a shattered window and a door with an exit sign above it.";
                    redTextLabel.Text = "Open the door.";
                    blueTextLabel.Text = "Jump through window.";
                    greenTextLabel.Text = "";
                    yellowTextLabel.Text = "";
                    break;
                case 7:
                    outputLabel.Text = "You jump through the window, and end up in front of the door you originally entered through. However, you cut yourself badly on the glass. You bleed to death.";
                    redTextLabel.Text = "Continue";
                    blueTextLabel.Text = "Continue";
                    greenButtonLabel.Text = "Continue";
                    yellowButtonLabel.Text = "Continue";
                    break;
                case 8:
                    outputLabel.Text = "After thinking about your previous path and the apparent size of the house from outside, you realize that the next door must take you outside. As you go through, however, you see a dimly lit hallway. As you turn around to go back through the door, it vanishes. You enter the hallway. You see an open doorway with a dark figure in it, and a closed door, with a red light coming from behind it.";
                    redTextLabel.Text = "Approach the creature.";
                    blueTextLabel.Text = "Enter the door.";
                    greenTextLabel.Text = "";
                    yellowTextLabel.Text = "";
                    break;
                case 9:
                    outputLabel.Text = "You begin to quietly approach the creature, when you suddenly hear a loud bang, followed by the creature collapsing. The noise scares you, and you jump, causing your feet to bang against the floor.";
                    redTextLabel.Text = "Run away.";
                    blueTextLabel.Text = "Continue.";
                    greenTextLabel.Text = "";
                    yellowTextLabel.Text = "";
                    break;
                case 10:
                    outputLabel.Text = "You continue forwards. You decide to yell out 'Hey!' to get the attention of whatever caused the creatures demise. You hear quick footsteps as your only response. The creature is leaking a green gas, and is holding a note.";
                    redTextLabel.Text = "Chase the footsteps.";
                    blueTextLabel.Text = "Read the note.";
                    greenTextLabel.Text = "";
                    yellowTextLabel.Text = "";
                    break;
                case 11:
                    outputLabel.Text = "You start sprinting towards where you heard the footsteps, and a banging starts ringing through the area. You stop to take your breath, and continue to chase the banging, but all you find is a window that is boarded from the outside. You begin to feel dizzy and smell something awful. You turn around and look at the creature. You asphyxiate.";
                    redTextLabel.Text = "Continue";
                    blueTextLabel.Text = "Continue";
                    greenButtonLabel.Text = "Continue";
                    yellowButtonLabel.Text = "Continue";
                    break;
                case 12:
                    outputLabel.Text = "You pick up the note. It is in your writing, and seems to be directed towards you. 'When you are as old as I, you must return and do as I have. Do not break the loop.' You roll the creature on it's side to check for more notes, and the green gas stops emitting. You realize why when you see a spray bottle labelled as poison under the creature.";
                    redTextLabel.Text = "Take the poison.";
                    blueTextLabel.Text = "Leave without it.";
                    greenTextLabel.Text = "";
                    yellowTextLabel.Text = "";
                    break;
                case 13:
                    if (hasPoison == true)
                    {
                        outputLabel.Text = "You make your way out of the area, and back towards the hallway. You see the closed door with a red light behind it that you saw earlier as your only path forwards. \n\nThe poison in your hand is starting to look appetizing.";
                        redTextLabel.Text = "Enter the room.";
                        blueTextLabel.Text = "Drink the poison.";
                        greenTextLabel.Text = "";
                        yellowTextLabel.Text = "";
                    }
                    else
                    {
                        outputLabel.Text = "You make your way out of the area, and back towards the hallway. You see the closed door with a red light behind it that you saw earlier as your only path forwards. ";
                        outputLabel.Text = "You make your way out of the area, and back towards the hallway. You see the closed door with a red light behind it that you saw earlier as your only path forwards. \n\nThe poison in your hand is starting to look appetizing.";
                        redTextLabel.Text = "Continue.";
                        blueTextLabel.Text = "Continue.";
                        greenTextLabel.Text = "Continue.";
                        yellowTextLabel.Text = "Continue.";
                    }
                    break;
                case 14:
                    outputLabel.Text = "You enter the room, and are immediately blinded by the red light. You lose orientation, and collapse to the ground. As your vision adjusts, you see that your leg has a massive gash from shattered glass on the floor. You are bleeding heavily.";
                    redTextLabel.Text = "Bandage.";
                    blueTextLabel.Text = "Ignore.";
                    if (hasPoison == true)
                    {
                        greenTextLabel.Text = "Clot the wound with the poison.";
                        yellowTextLabel.Text = "Clot the wound with the poison.";
                    }
                    else
                    {
                        greenTextLabel.Text = "";
                        yellowTextLabel.Text = "";
                    }


                    break;
                case 15:
                    if (hasPoison == true)
                    {
                        outputLabel.Text = "You soon find yourself unable to walk, and your thoughts are foggy. \n\nYour appetite for the poison grows.";
                        redTextLabel.Text = "Drink the poison.";
                        blueTextLabel.Text = "Do not drink the poison.";
                        greenTextLabel.Text = "";
                        yellowTextLabel.Text = "";
                    }
                    else
                    {
                        outputLabel.Text = "You soon find yourself unable to walk, and your thoughts are foggy. \n\nYou die of severe blood-loss.";
                        redTextLabel.Text = "Continue.";
                        blueTextLabel.Text = "Continue.";
                        greenTextLabel.Text = "Continue.";
                        yellowTextLabel.Text = "Continue.";
                    }
                    break;
                case 16:
                    outputLabel.Text = "Despite the overwhelming desire you have to drink the poison, you resist. You soon die to blood-loss.";
                    redTextLabel.Text = "Continue.";
                    blueTextLabel.Text = "Continue.";
                    greenTextLabel.Text = "Continue.";
                    yellowTextLabel.Text = "Continue.";
                    break;
                case 17:
                    if (scene17Out == false)
                    {
                        outputLabel.Text = "Your bandage is functional and sturdy, and you appear to not be losing anymore blood! However, you still feel cold from your previous blood-loss, and you no longer have a shirt to protect you. You freeze to death.";
                        redTextLabel.Text = "Continue.";
                        blueTextLabel.Text = "Continue.";
                        greenTextLabel.Text = "Continue.";
                        yellowTextLabel.Text = "Continue.";
                    }
                    else
                    {
                        outputLabel.Text = "You immediately feel better after applying the bandage, and are no longer leaking blood. you see two shattered windows that appear to lead outside.";
                        redTextLabel.Text = "Left.";
                        blueTextLabel.Text = "Right.";
                        greenTextLabel.Text = "";
                        yellowTextLabel.Text = "";
                    }
                    break;
                case 18:
                    break;
                case 19:
                    break;
                case 20:
                    break;
                case 21:
                    break;
                case 22:
                    break;
                case 23:
                    break;
                case 24:
                    break;
                case 25:
                    break;
                case 26:
                    break;
                case 27:
                    break;
                case 28:
                    break;
                case 29:
                    break;
                case 30:
                    break;
                case 31:
                    break;
                case 32:
                    break;
                case 33:
                    break;
                case 34:
                    break;
                case 99:
                    break;
            }
        }
    }
}
