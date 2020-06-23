using System;

namespace BuilderPattern
{
    /// <summary>
    /// 消费活动
    /// </summary>
    public class ConsumeActivity : BaseActivity
    {
        public ConsumeActivity(string userName)
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
            Console.WriteLine("【消费活动】获取消费活动的判断条件");
        }

        protected override void IsMeetJoinCondition()
        {
            Console.WriteLine($"【消费活动】判断{UserName}近3天是否有消费行为");
        }

        protected override void IsMeetSentAwardCondition()
        {
            Console.WriteLine($"【消费活动】{UserName}消费金额是否大于100元");
        }

        protected override void IsReceivedAward()
        {
            Console.WriteLine($"【消费活动】{UserName}今日是否已经获得消费奖励");
        }

        protected override void SendAward()
        {
            Console.WriteLine($"【消费活动】发放5元优惠券给{UserName}");
        }

        protected override void LogAwardRecord()
        {
            Console.WriteLine($"【消费活动】记录{UserName}今天参与消费活动");
        }
    }
}
