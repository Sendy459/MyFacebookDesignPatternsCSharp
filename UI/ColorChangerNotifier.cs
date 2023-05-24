using System;
using System.Windows.Forms;

namespace UI
{
    internal class ColorChangerNotifier : Button
    {
        public event Action<int> m_ReportColorChangeDelegates;

        private int m_CurrentColor = 1; 

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);   
            m_CurrentColor = (m_CurrentColor % 4) + 1; // Allow at most 4 colors for now, extensible
            notifyChangeColorObservers(); 
        }

        private void notifyChangeColorObservers()
        {
            if (m_ReportColorChangeDelegates != null)
            {
                m_ReportColorChangeDelegates.Invoke(m_CurrentColor);
            }
        }
    }
}