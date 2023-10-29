//using contracts;
//using loggerservice;
//using repository;
//using service.contracts;
//using service;
//using microsoft.entityframeworkcore;

//namespace jucarautopartes.extensions
//{
//    public static class serviceextensions
//    {
//        public static void configurecors(this iservicecollection services) =>
//            services.addcors(options =>
//            {
//                options.addpolicy("corspolicy", builder =>
//                    builder.allowanyorigin()
//                    .allowanymethod()
//                    .allowanyheader());
//            });

//        public static void configureiisintegration(this iservicecollection services) =>
//            services.configure<iisoptions>(options =>
//            {

//            });

//        public static void configureloggerservice(this iservicecollection services) =>
//            services.addsingleton<iloggermanager, loggermanager>();

//        public static void configurerepositorymanager(this iservicecollection services) =>
//            services.addscoped<irepositorymanager, repositorymanager>();

//        public static void configureservicemanager(this iservicecollection services) =>
//            services.addscoped<iservicemanager, servicemanager>();

//        public static void configuresqlcontext(this iservicecollection services, iconfiguration configuration) =>
//            services.adddbcontext<repositorycontext>(opts =>
//                opts.usesqlserver(configuration.getconnectionstring("sqlconnection")));

//        public static imvcbuilder addcustomcsvformatter(this imvcbuilder builder) =>
//            builder.addmvcoptions(config => config.outputformatters.add(new csvoutputformatter()));

//    }
//}
