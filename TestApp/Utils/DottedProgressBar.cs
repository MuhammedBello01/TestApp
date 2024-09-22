using System;
using Android.Content;
using Android.Graphics;
using Android.Hardware.Lights;
using Android.Util;
using Android.Views;
using static Android.Icu.Text.ListFormatter;

namespace TestApp.Utils
{
	public class DottedProgressBar : View
    {
        private Paint _paint;
        private int _dotCount;
        private float _angleIncrement;
        private float _currentAngle;
        private float _minDotSize;
        private float _maxDotSize;

        public DottedProgressBar(Context context, IAttributeSet attrs) : base(context, attrs)
        {
            Initialize();
        }

        public DottedProgressBar(Context context) : base(context)
        {
            Initialize();
        }

        private void Initialize()
        {
            // Paint settings
            _paint = new Paint
            {
                Color = Color.ParseColor("#A90836"), // Dot color
                AntiAlias = true
            };

            _paint.SetStyle(Paint.Style.Fill);

            // Dotted circle settings
            _dotCount = 8;               // Number of dots in the circle
            _angleIncrement = 360f / _dotCount; // Space the dots evenly in a circle
            _currentAngle = 0;            // Starting angle

            // Dot size range
            _minDotSize = 2f;  // Minimum dot size
            _maxDotSize = 7f; // Maximum dot size
        }

        protected override void OnDraw(Canvas canvas)
        {
            base.OnDraw(canvas);

            float centerX = Width / 2;
            float centerY = Height / 2;
            float radius = Math.Min(centerX, centerY) - _maxDotSize; // Ensure dots fit within the view

            for (int i = 0; i < _dotCount; i++)
            {
                // Gradually increase the size of the dots
                float dotSize = _minDotSize + ((float)i / _dotCount) * (_maxDotSize - _minDotSize);

                // Calculate the position of each dot in the circle
                //float angleRadians = (float)Math.ToRadians(i * _angleIncrement + _currentAngle);
                float angleRadians = (float)((i * _angleIncrement + _currentAngle) * (Math.PI / 180));
                float x = centerX + (float)(radius * Math.Cos(angleRadians));
                float y = centerY + (float)(radius * Math.Sin(angleRadians));

                // Draw the dot
                canvas.DrawCircle(x, y, dotSize, _paint);
            }

            // Optionally, you can animate the dots by rotating them over time
            _currentAngle += 3; // Slowly rotate the dots
            Invalidate(); // Redraw the view for animation
        }
    }
}


