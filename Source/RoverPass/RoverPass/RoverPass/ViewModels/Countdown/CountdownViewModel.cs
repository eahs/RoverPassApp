using System;
using Xamarin.Forms;
namespace RoverPass.ViewModels
{
    public class CountdownViewModel : BaseViewModel
    {
        private TimeSpan countdownTime;
        public event EventHandler CountdownCompleted;
        public void Start(TimeSpan span)
        {
            this.countdownTime = span;
           
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                // Update timer property
                countdownTime.Subtract(new TimeSpan(0, 0, 0, 1));
                OnPropertyChanged("CountdownTime");
                if (countdownTime.TotalSeconds <= 0)
                {
                    OnCountdownCompleted();
                    return false;
                }
                return true;
            });
        }

        public TimeSpan CountdownTimeSpan
        {
            get
            {
                return countdownTime;
            }
        }
        public string CountdownTime
        {
            get
            {
                if (countdownTime.TotalSeconds <= 0)
                    countdownTime = new TimeSpan(0, 0, 0);
                return countdownTime.ToString(@"{0:hh\:mm\:ss}");
            }
        }
        protected virtual void OnCountdownCompleted()
        {
            CountdownCompleted?.Invoke(this, new EventArgs());


        }
        private void CountdownViewModel_CountdownCompleted(object sender, EventArgs e)
        {
            
        }
    }

}