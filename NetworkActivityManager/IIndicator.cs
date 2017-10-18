namespace Pawotter.NetworkActivityManager
{
    interface IIndicator
    {
        /// <summary>
        /// Activate indicator.
        /// </summary>
        void Activate();

        /// <summary>
        /// Inactivate indicator.
        /// </summary>
        void Inactivate();
    }
}
