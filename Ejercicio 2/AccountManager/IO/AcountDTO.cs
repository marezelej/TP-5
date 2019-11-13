using System;

namespace AccountManager.IO
{
    class AcountDTO
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public double OverDraftLimit { set; get; }
        public double Balance { set; get; }

    }
}
