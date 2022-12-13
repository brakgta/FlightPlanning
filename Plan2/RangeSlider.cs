using System.Windows.Forms;

namespace Plan2
{
    public class RangeSlider : TrackBar
    {
        private int _minimumRange;
        private int _maximumRange;

        public int MinimumRange
        {
            get { return _minimumRange; }
            set
            {
                _minimumRange = value;
                UpdateRange();
            }
        }

        public int MaximumRange
        {
            get { return _maximumRange; }
            set
            {
                _maximumRange = value;
                UpdateRange();
            }
        }

        public RangeSlider()
        {
            _minimumRange = 0;
            _maximumRange = 100;
            Refresh();
            UpdateRange();
        }

        private void UpdateRange()
        {
            if (_minimumRange < _maximumRange)
            {
                Minimum = _minimumRange;
                Maximum = _maximumRange;
            }
            else
            {
                Minimum = _maximumRange;
                Maximum = _minimumRange;
            }
        }
    }
}
