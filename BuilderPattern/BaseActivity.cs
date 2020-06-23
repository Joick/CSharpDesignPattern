namespace BuilderPattern
{
    /// <summary>
    /// 活动基类
    /// </summary>
    public abstract class BaseActivity
    {
        protected string UserName;

        protected BaseActivity(string userName)
        {
            UserName = userName;
        }

        /// <summary>
        /// 参加活动
        /// </summary>
        public abstract void JoinActivity();

        /// <summary>
        /// 检查货活动条件
        /// </summary>
        protected abstract void CheckJoinCondition();

        /// <summary>
        /// 判断用户是否满足参加活动条件
        /// </summary>
        protected abstract void IsMeetJoinCondition();

        /// <summary>
        /// 是否满足发放奖励条件
        /// </summary>
        protected abstract void IsMeetSentAwardCondition();

        /// <summary>
        /// 是否已经发放过奖励
        /// </summary>
        protected abstract void IsReceivedAward();

        /// <summary>
        /// 发放奖励
        /// </summary>
        protected abstract void SendAward();

        /// <summary>
        /// 记录发放记录
        /// </summary>
        protected abstract void LogAwardRecord();
    }
}
