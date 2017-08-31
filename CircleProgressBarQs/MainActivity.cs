using Android.App;
using Android.Widget;
using Android.OS;
using Com.Dinuscxj.Progressbar;
using Android.Animation;
using System;

namespace CircleProgressBarQs
{
    [Activity(Label = "CircleProgressBarQs", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity, ValueAnimator.IAnimatorUpdateListener
    {
        private CircleProgressBar mLineProgressBar;
        private CircleProgressBar mSolidProgressBar;
        private CircleProgressBar mCustomProgressBar1;
        private CircleProgressBar mCustomProgressBar2;
        private CircleProgressBar mCustomProgressBar3;
        private CircleProgressBar mCustomProgressBar4;
        private CircleProgressBar mCustomProgressBar5;
        private CircleProgressBar mCustomProgressBar6;

        public void OnAnimationUpdate(ValueAnimator animation)
        {
            int progress = (int)animation.AnimatedValue;
            mLineProgressBar.Progress=progress;
            mSolidProgressBar.Progress=progress;
            mCustomProgressBar1.Progress=progress;
            mCustomProgressBar2.Progress=progress;
            mCustomProgressBar3.Progress=progress;
            mCustomProgressBar4.Progress=progress;
            mCustomProgressBar5.Progress=progress;
            mCustomProgressBar6.Progress=progress;

        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.activity_main);

            mLineProgressBar = (CircleProgressBar)FindViewById(Resource.Id.line_progress);
            mSolidProgressBar = (CircleProgressBar)FindViewById(Resource.Id.solid_progress);
            mCustomProgressBar1 = (CircleProgressBar)FindViewById(Resource.Id.custom_progress1);
            mCustomProgressBar2 = (CircleProgressBar)FindViewById(Resource.Id.custom_progress2);
            mCustomProgressBar3 = (CircleProgressBar)FindViewById(Resource.Id.custom_progress3);
            mCustomProgressBar4 = (CircleProgressBar)FindViewById(Resource.Id.custom_progress4);
            mCustomProgressBar5 = (CircleProgressBar)FindViewById(Resource.Id.custom_progress5);
            mCustomProgressBar6 = (CircleProgressBar)FindViewById(Resource.Id.custom_progress6);
        }

        protected override void OnResume()
        {
            base.OnResume();
            simulateProgress();
        }
        private void simulateProgress()
        {
            ValueAnimator animator = ValueAnimator.OfInt(0, 100);
            animator.AddUpdateListener(this);
            animator.RepeatCount = ValueAnimator.Infinite;
            animator.SetDuration(4000);
            animator.Start();
        }
    }
}

