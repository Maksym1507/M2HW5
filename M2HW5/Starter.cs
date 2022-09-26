using M2HW5.Exceptions;
using M2HW5.Interfaces;

namespace M2HW5
{
    public class Starter
    {
        public Starter(ILogger logger, IActions actions)
        {
            Logger = logger;
            Actions = actions;
        }

        private ILogger Logger { get; }

        private IActions Actions { get; }

        public void Run()
        {
            for (int i = 0; i < 100; i++)
            {
                 var random = new Random();

                 try
                 {
                    switch (random.Next(1, 4))
                    {
                        case 1:
                            Actions.CallInfo();
                            break;
                        case 2:
                            Actions.CallWarning();
                            break;
                        case 3:
                            Actions.CallError();
                            break;
                    }
                 }
                 catch (BusinessException ex)
                 {
                    Logger.LogWarning($"Action got this custom Exception: {ex.Message}");
                 }
                 catch (Exception ex)
                 {
                    Logger.LogError($"Action failed by reason: {ex.Message}");
                 }
            }
        }
    }
}
