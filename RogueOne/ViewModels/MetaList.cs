namespace RogueOne.ViewModels
{
    public class MetaList
    {
        public StatusData? Data { get; set; }
    }
    public class PageInfo
    {
        public bool HasNextPage { get; set; }
        public string? EndCursor { get; set; }
    }

    public class DisplayResource
    {
        public string? Src { get; set; }
        public int ConfigWidth { get; set; }
        public int ConfigHeight { get; set; }
    }

    public class MetaList_SharingFrictionInfo
    {
        public bool ShouldHaveSharingFriction { get; set; }
        public string? BloksAppUrl { get; set; }
    }

    public class MediaNode
    {
        public string? Typename { get; set; }
        public string? Id { get; set; }
        public object? GatingInfo { get; set; }
        public object? FactCheckOverallRating { get; set; }
        public object? FactCheckInformation { get; set; }
        public object? MediaOverlayInfo { get; set; }
        public object? SensitivityFrictionInfo { get; set; }
        public MetaList_SharingFrictionInfo? SharingFrictionInfo { get; set; }
        public Dimensions? Dimensions { get; set; }
        public string? DisplayUrl { get; set; }
        public List<DisplayResource>? DisplayResources { get; set; }
        public bool IsVideo { get; set; }
        public string? MediaPreview { get; set; }
        public string? TrackingToken { get; set; }
        public bool HasUpcomingEvent { get; set; }
        public EdgeMediaToCaption? EdgeMediaToCaption { get; set; }
        public string? Shortcode { get; set; }
        public EdgeMediaToComment? EdgeMediaToComment { get; set; }
        public EdgeMediaToSponsorUser? EdgeMediaToSponsorUser { get; set; }
        public bool IsAffiliate { get; set; }
        public bool IsPaidPartnership { get; set; }
        public bool CommentsDisabled { get; set; }
        public long TakenAtTimestamp { get; set; }
        public EdgeMediaPreviewLike? EdgeMediaPreviewLike { get; set; }
        public string? ThumbnailSrc { get; set; }
        public List<DisplayResource>? ThumbnailResources { get; set; }
    }

    public class Dimensions
    {
        public int Height { get; set; }
        public int Width { get; set; }
    }

    public class EdgeMediaToCaption
    {
        public List<EdgeMediaToCaptionNode>? Edges { get; set; }
    }

    public class EdgeMediaToCaptionNode
    {
        public EdgeMediaToCaptionNodeNode? Node { get; set; }
    }

    public class EdgeMediaToCaptionNodeNode
    {
        public string? Text { get; set; }
    }

    public class EdgeMediaToComment
    {
        public int Count { get; set; }
        public PageInfo? PageInfo { get; set; }
    }

    public class EdgeMediaToSponsorUser
    {
        public List<object>? Edges { get; set; }
    }

    public class EdgeMediaPreviewLike
    {
        public int Count { get; set; }
        public List<EdgeMediaPreviewLikeNode>? Edges { get; set; }
    }

    public class EdgeMediaPreviewLikeNode
    {
        public EdgeMediaPreviewLikeNodeNode? Node { get; set; }
    }

    public class EdgeMediaPreviewLikeNodeNode
    {
        public string? Id { get; set; }
        public string? ProfilePicUrl { get; set; }
        public string? Username { get; set; }
    }

    public class MetaList_User
    {
        public EdgeOwnerToTimelineMedia? EdgeOwnerToTimelineMedia { get; set; }
    }

    public class EdgeOwnerToTimelineMedia
    {
        public int Count { get; set; }
        public PageInfo? PageInfo { get; set; }
        public List<Edge>? Edges { get; set; }
    }

    public class Edge
    {
        public MediaNode? Node { get; set; }
    }

    public class MetaList_Location
    {
        public string? Id { get; set; }
        public bool HasPublicPage { get; set; }
        public string? Name { get; set; }
        public string? Slug { get; set; }
    }

    public class StatusData
    {
        public MetaList_User? Data { get; set; }
        public string? Status { get; set; }
        public string? Attempts { get; set; }
    }
}
