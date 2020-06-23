using System;

namespace BuilderPattern
{
    /// <summary>
    /// 充值活动
    /// </summary>
    public class RechargeActivity : BaseActivity
    {
        public RechargeActivity(string userName)
        : base(userName)
        {
        }

        public override void JoinActivity()
        {
            CheckJoinCondition();
            IsMeetJoinCondition();
            IsMeetSentAwardCondition();
            IsReceivedAward();
            SendAward();
            LogAwardRecord();
        }

        protected override void CheckJoinCondition()
        {
            Console.WriteLine("【充值活动】获取充值活动的判断条件");
        }

        protected override void IsMeetJoinCondition()
        {
            Console.WriteLine($"【充值活动】{UserName}今天是否还未充值");
        }

        protected override void IsMeetSentAwardCondition()
        {
            Console.WriteLine($"【充值活动】{UserName}充值金额是否大于100元");
        }

        protected override void IsReceivedAward()
        {
            Console.WriteLine($"【充值活动】{UserName}今日是否已经获得充值奖励");
        }

        protected override void SendAward()
        {
            Console.WriteLine($"【充值活动】发放10元优惠券给{UserName}");
        }

        protected override void LogAwardRecord()
        {
            Console.WriteLine($"【充值活动】记录{UserName}今天参与充值活动");
        }
    }
}
