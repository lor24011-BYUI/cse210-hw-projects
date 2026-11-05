using System;

class BreathingActivity : BaseActivity
{
        public void RunActivity()
    {
        // Call Start

        RunCountDownMessage("Get Ready", 5);
        DateTime endTime = DateTime.Now.AddSeconds(20);
        

        while (DateTime.Now < endTime)
        {
            RunCountDownMessage("Breath In", 4);
            RunCountDownMessage("Breath Out", 6);

        }
        
        // Call EndActivity
    }
}