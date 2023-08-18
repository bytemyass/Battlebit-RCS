using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BBR
{
    static class Program
    {
        
        [STAThread]
        static void Main()
        {
            
            Thread recoilthread = new Thread(Recoil);
            recoilthread.Start();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BBR());
        }

        // Begin Recoil Stuff //



        // Do not change:
        static float accumulatedRecoil = 0;
        static float accumulatedSleepFraction = 0;
        static int baseFov = 90;
        static int baseSens = 100;
        static int smoothSteps = BBR.smoothing;
        static int fov = BBR.fov;
        static int sens = BBR.sens;
        


        

        static Dictionary<string, float[]> Weapons = new Dictionary<string, float[]>
         {
    // BEFORE USING, CHANGE VALUES HERE TO THE ONES YOU WANT 
    //   "WEAPON"              RECOIL, FIRERATE
        // AR
        { "AK74", new float[] { 1.50f, 670f } },
        { "M4A1", new float[] { 1.50f, 700f } },
        { "AK15", new float[] { 1.60f, 540f } },
        { "SCAR", new float[] { 1.60f, 500f } },
        { "AUG", new float[] { 1.20f, 500f } },
        { "SG550", new float[] { 0.90f, 700f } },
        { "FAMAS", new float[] { 1.40f, 900f } },
        { "ACR", new float[] { 1.40f, 700f } },
        { "G36C", new float[] { 1.40f, 750f } },
        { "HK419", new float[] { 1.40f, 660f } },
        { "FAL", new float[] { 2.02f, 650f } },
        { "AK5C", new float[] { 2.13f, 600f } },
        
        // SMG
        { "MP7", new float[] { 1.00f, 950f } },
        { "UMP-45", new float[] { 0.90f, 700f } },
        { "PP2000", new float[] { 1.20f, 900f } },
        { "PP19", new float[] { 0.90f, 750f } },
        { "VECTOR", new float[] { 1.00f, 1200f } },
        { "MP5", new float[] { 0.90f, 800f } },
        
        // PDW
        { "H-BADGER", new float[] { 1.50f, 800f } },
        { "GROZA", new float[] { 1.20f, 650f } },
        { "P90", new float[] { 1.16f, 800f } },
        
        // CARBINE
        { "AS-VAL", new float[] { 1.50f, 800f } },
        { "SCORPION", new float[] { 2.70f, 1200f } },
        
        // LSG/LMG
        { "L86A1", new float[] { 1.40f, 775f } },
        { "MG36", new float[] { 1.80f, 600f } },
        { "M249", new float[] { 1.10f, 700f } },
        { "ULTIMAX", new float[] { 1.50f, 600f } }
         };


        static int Round(float num)
        {
            return (int)Math.Floor(num + 0.5);
        }
        static void Recoil()
        {
            
            
            while (true)
            {
                
                
                float[] props = Weapons[BBR.selection];
                float recoilY = (props[0] * 19.5f * ((float)fov / baseFov) / ((float)sens / baseSens));

                if (smoothSteps > 1)
                {
                    recoilY = recoilY / smoothSteps;
                }

                float fireRate = (60000f / props[1]) / smoothSteps;

                while (BBR.active && MH.IsKeyDown(Keys.LButton) && MH.IsKeyDown(Keys.RButton)) 
                {
                    float totalRecoil = recoilY + accumulatedRecoil;
                    int integerRecoil = Round(totalRecoil);
                    accumulatedRecoil = totalRecoil - integerRecoil;
                    accumulatedSleepFraction = accumulatedSleepFraction + (fireRate % 1);

                    float totalDelay = fireRate + accumulatedSleepFraction;
                    int integerDelay = (int)Math.Floor(totalDelay);
                    accumulatedSleepFraction = totalDelay - integerDelay;


                    MH.RelativeMove(0, integerRecoil);
                    Console.WriteLine("Moving mouse by y:  " + integerRecoil + ".    delay:  " + integerDelay);

                    if (accumulatedSleepFraction >= 1)
                    {
                        integerDelay = integerDelay - 1;
                        accumulatedSleepFraction = accumulatedSleepFraction - 1;
                    }
                    Thread.Sleep(integerDelay);

                } 
                }
            }








        }
}
