using System;
using System.Collections.Generic;

namespace RogueOne.ViewModels
{
    public class UserDetails
    {
        public List<Item>? Items { get; set; }
        public PagingInfo? PagingInfo { get; set; }
        public string? Status { get; set; }
        public string? Attempts { get; set; }
    }

    public class Item
    {
        public Media? Media { get; set; }
    }

    public class Media
    {
        public string? Pk { get; set; }
        public string? Id { get; set; }
        public string? Fbid { get; set; }
        public long DeviceTimestamp { get; set; }
        public bool CaptionIsEdited { get; set; }
        public  string? StrongId { get; set; }
        public int DeletedReason { get; set; }
        public int HasSharedToFb { get; set; }
        public bool HasDelayedMetadata { get; set; }
        public string? MezqlToken { get; set; }
        public bool ShareCountDisabled { get; set; }
        public bool ShouldRequestAds { get; set; }
        public bool IsReshareOfTextPostAppMediaInIg { get; set; }
        public string? IntegrityReviewDecision { get; set; }
        public string? ClientCacheKey { get; set; }
        public int FilterType { get; set; }
        public bool IsVisualReplyCommenterNoticeEnabled { get; set; }
        public bool LikeAndViewCountsDisabled { get; set; }
        public bool HasPrivatelyLiked { get; set; }
        public bool IsPostLiveClipsMedia { get; set; }
        public bool IsQuietPost { get; set; }
        public string? SubtypeNameForRest { get; set; }
        public long TakenAt { get; set; }
        public bool HasTaggedUsers { get; set; }
        public bool PhotoOfYou { get; set; }
        public bool CanSeeInsightsAsBrand { get; set; }
        public int MediaType { get; set; }
        public string? Code { get; set; }
        public Caption? Caption { get; set; }
        public FundraiserTag? FundraiserTag { get; set; }
        public SharingFrictionInfo? SharingFrictionInfo { get; set; }
        public string? DisplayUri { get; set; }
        public List<VideoVersion>? VideoVersions { get; set; }
        public Location? Location { get; set; }
        public string? OrganicTrackingToken { get; set; }
        public bool IsReuseAllowed { get; set; }
    }

    public class Caption
    {
        public int BitFlags { get; set; }
        public long CreatedAt { get; set; }
        public long CreatedAtUtc { get; set; }
        public bool DidReportAsSpam { get; set; }
        public bool IsRankedComment { get; set; }
        public string? Pk { get; set; }
        public bool ShareEnabled { get; set; }
        public string? ContentType { get; set; }
        public string? MediaId { get; set; }
        public string? Status { get; set; }
        public int Type { get; set; }
        public string? UserId { get; set; }
        public string? StrongId { get; set; }
        public string? Text { get; set; }
        public User? User { get; set; }
        public bool IsCovered { get; set; }
        public int PrivateReplyStatus { get; set; }
    }

    public class User
    {
        public string? Pk { get; set; }
        public string? PkId { get; set; }
        public string? Id { get; set; }
        public string? FullName { get; set; }
        public bool IsPrivate { get; set; }
        public bool IsUnpublished { get; set; }
        public string? StrongId { get; set; }
        public string? FbidV2 { get; set; }
        public string? Username { get; set; }
        public bool IsVerified { get; set; }
        public string? ProfilePicId { get; set; }
        public string? ProfilePicUrl { get; set; }
    }

    public class FundraiserTag
    {
        public bool HasStandaloneFundraiser { get; set; }
    }

    public class SharingFrictionInfo
    {
        public string? BloksAppUrl { get; set; }
        public bool ShouldHaveSharingFriction { get; set; }
        public string? SharingFrictionPayload { get; set; }
    }

    public class VideoVersion
    {
        public string? Url { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int Type { get; set; }
        public object? Bandwidth { get; set; }
    }

    public class Location
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public bool HasViewerSaved { get; set; }
        public string? Pk { get; set; }
        public string? ShortName { get; set; }
        public string? FacebookPlacesId { get; set; }
        public string? ExternalSource { get; set; }
        public double Lng { get; set; }
        public double Lat { get; set; }
    }

    public class PagingInfo
    {
        public string? MaxId { get; set; }
        public bool MoreAvailable { get; set; }
    }

}
