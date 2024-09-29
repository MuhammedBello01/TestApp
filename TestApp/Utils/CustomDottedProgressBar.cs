using System;
using Android.Content;
using Android.Graphics;
using Android.Hardware.Lights;
using Android.OS;
using Android.Util;
using Android.Views;
using static Android.Icu.Text.ListFormatter;

namespace TestApp.Utils
{
	public class CustomDottedProgressBar : View
    {
        private Handler _handler;
        private Action _updateAction;
        private int _currentAngle = 0;
        private int _angleIncrement = 2; // Speed control, default value
        private int _updateDelay = 16;   // Delay between updates, default (about 60 FPS)

        private int _dotCount = 12;      // Number of dots, default
        private float _minDotSize = 5f;  // Minimum dot size, default
        private float _maxDotSize = 20f; // Maximum dot size, default

        private Paint _paint;
        private bool isRunning = true;

        public CustomDottedProgressBar(Context context, IAttributeSet attrs) : base(context, attrs)
        {
            Initialize();
            _handler = new Handler(Looper.MainLooper);  // Use the main thread looper
            _updateAction = new Action(Update);
            _handler.PostDelayed(_updateAction, _updateDelay); // Start the update cycle
        }

        private void Initialize()
        {
            _paint = new Paint
            {
                AntiAlias = true,
                Color = Color.ParseColor("#A90836")
            };
        }

        private void Update()
        {
            if (!isRunning) return;
            _currentAngle += _angleIncrement; // Adjust the speed by controlling angle increment
            Invalidate();
            _handler.PostDelayed(_updateAction, _updateDelay); // Continue the loop with the specified delay
        }


        public void Start()
        {
            if (isRunning) return; // Don't start again if already animating
            isRunning = true;       // Set to true when the animation starts
            if (_handler == null)
            {
                _handler = new Handler(Looper.MainLooper);  // Initialize the handler if it's null
            }
            _handler.PostDelayed(_updateAction, _updateDelay); // Start the update cycle
        }

        public void Stop()
        {          
            if (isRunning) // Check if currently running
            {
                isRunning = false;
                _handler.RemoveCallbacks(_updateAction); // Stop the updates
               
            }
        }

        // Public properties to control the behavior from outside the class
        public int Speed
        {
            get => _angleIncrement;
            set
            {
                _angleIncrement = value; // Adjust the speed
            }
        }

        public int FrameRate
        {
            get => _updateDelay;
            set
            {
                _updateDelay = value;
                _handler.RemoveCallbacks(_updateAction); // Restart the handler with the new delay
                _handler.PostDelayed(_updateAction, _updateDelay);
            }
        }

        public int DotCount
        {
            get => _dotCount;
            set
            {
                _dotCount = value;
                Invalidate(); // Redraw with the new dot count
            }
        }

        public float MinDotSize
        {
            get => _minDotSize;
            set
            {
                _minDotSize = value;
                Invalidate(); // Redraw with the new minimum dot size
            }
        }

        public float MaxDotSize
        {
            get => _maxDotSize;
            set
            {
                _maxDotSize = value;
                Invalidate(); // Redraw with the new maximum dot size
            }
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
                float angleRadians = (float)((i * (360 / _dotCount) + _currentAngle) * (Math.PI / 180));
                float x = centerX + (float)(radius * Math.Cos(angleRadians));
                float y = centerY + (float)(radius * Math.Sin(angleRadians));

                // Draw the dot
                canvas.DrawCircle(x, y, dotSize, _paint);
            }
        }

        protected override void Dispose(bool disposing)
        {
            _handler.RemoveCallbacks(_updateAction); // Stop updates when disposing
            base.Dispose(disposing);
        }
    }
}

