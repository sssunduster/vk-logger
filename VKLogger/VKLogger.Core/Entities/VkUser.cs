namespace VKLogger.Core.Entities
{
    public class VkUser
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MaidenName { get; set; }
        public string ScreenName { get; set; }
        public int Sex { get; set; }
        public string Domain { get; set; }
        public int CityId { get; set; }
        public int CountryId { get; set; }
        public string HomeTown { get; set; }
        public string Photo50 { get; set; }
        public string Photo100 { get; set; }
        public string Photo200Orig { get; set; }
        public string Photo200 { get; set; }
        public string Photo400Orig { get; set; }
        public string PhotoMax { get; set; }
        public string PhotoMaxOrig { get; set; }
        public bool HasMobile { get; set; }
        public bool HasSkype { get; set; }
        public bool HasFacebook { get; set; }
        public bool HasTwitter { get; set; }
        public bool HasInstagram { get; set; }
        public bool HasLivejournal { get; set; }
        public bool HasOnline { get; set; }
        public int[] Lists { get; set; }
        public bool IsFriend { get; set; }
        public bool IsFavorite { get; set; }
        public bool IsHiddenFromFeed { get; set; }
        public int TimeZone { get; set; }
        public string[] Languages { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsDeactivated { get; set; }
        public string About { get; set; }
        public string Activities { get; set; }
        public string Interests { get; set; }
        public string Music { get; set; }
        public string Movies { get; set; }
        public string Tv { get; set; }
        public string Books { get; set; }
        public string Games { get; set; }
        public string Quotes { get; set; }
        public string[] Connections { get; set; }
        public VkUserCounters Counters { get; set; }
        public VkLastSeen LastSeen { get; set; }
        public VkPersonal Personal { get; set; }


        //TBD
        //public VkOccupation Occupation { get; set; }
        //public VkSchool[] Schools { get; set; }
        //public VkUniversity[] Universities { get; set; }
        //public VkCareer[] Career { get; set; }
        //public VkMilitary Military { get; set; }
        //public VkRelation Relation { get; set; }
        //public VkExports Exports { get; set; }
        //public VkCropPhoto CropPhoto { get; set; }
        public bool Verified { get; set; }
        public int Site { get; set; }
        public string Status { get; set; }
        public VkStatusAudio StatusAudio { get; set; }
        public bool? CanAccessClosed { get; set; }
        public bool? IsClosed { get; set; }
        public bool? CanInviteToChats { get; set; }
        public bool? IsService { get; set; }
        public bool? CanSeeAllPosts { get; set; }
        public bool? CanSeeAudio { get; set; }
        public bool? CanWritePrivateMessage { get; set; }
    }
}
