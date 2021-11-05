using NServiceBus;

namespace Library
{
    public static class LibraryClass
    {
        public static void Call() {
            new RabbitMQTransport();
        }
    }
}
