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
            isRunning = true;
            OnPropertyChanged("IsRunning");
            OnPropertyChanged("CountdownTime");

            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                // Update timer property
                countdownTime = countdownTime.Subtract(new TimeSpan(0, 0, 1));
                OnPropertyChanged("CountdownTime");

                if (countdownTime.TotalSeconds <= 0 || IsRunning == false)
                {
                    Stop();
                    OnCountdownCompleted();
                    return false;
                }
                return true;
            });
        }

        public void Stop()
        {
            if (IsRunning)
            {
                isRunning = false;
                OnPropertyChanged("IsRunning");
            }
        }

        private bool isRunning = false;
        public bool IsRunning {
            get
            {
                return isRunning;
            }
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
                if (isRunning)
                {
                    if (countdownTime.TotalSeconds <= 0)
                        countdownTime = new TimeSpan(0, 0, 0);

                    return countdownTime.ToString(@"mm\:ss");
                }

                return "";
            }
        }
        protected virtual void OnCountdownCompleted()
        {
            CountdownCompleted?.Invoke(this, new EventArgs());
        }

    }

}