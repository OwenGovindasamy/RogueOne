using Newtonsoft.Json;




namespace RogueOne.Models
{
    public partial class ReelListDetails
    {
        [JsonProperty("items")]
        public Item[] Items { get; set; }

        [JsonProperty("paging_info")]
        public PagingInfo PagingInfo { get; set; }

        [JsonProperty("status")]
        public string? Status { get; set; }

        [JsonProperty("attempts")]
        public int Attempts { get; set; }
    }

    public partial class Item
    {
        [JsonProperty("media")]
        public Media Media { get; set; }
    }

    public partial class Media
    {
        [JsonProperty("pk")]
        public string? Pk { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("fbid", NullValueHandling = NullValueHandling.Ignore)]
        public string? Fbid { get; set; }

        [JsonProperty("device_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long DeviceTimestamp { get; set; }

        [JsonProperty("caption_is_edited", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CaptionIsEdited { get; set; }

        [JsonProperty("strong_id__", NullValueHandling = NullValueHandling.Ignore)]
        public string? StrongId { get; set; }

        [JsonProperty("deleted_reason", NullValueHandling = NullValueHandling.Ignore)]
        public int? DeletedReason { get; set; }

        [JsonProperty("has_shared_to_fb", NullValueHandling = NullValueHandling.Ignore)]
        public int? HasSharedToFb { get; set; }

        [JsonProperty("has_delayed_metadata", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasDelayedMetadata { get; set; }

        [JsonProperty("mezql_token", NullValueHandling = NullValueHandling.Ignore)]
        public string? MezqlToken { get; set; }

        [JsonProperty("share_count_disabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShareCountDisabled { get; set; }

        [JsonProperty("should_request_ads", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShouldRequestAds { get; set; }

        [JsonProperty("is_reshare_of_text_post_app_media_in_ig", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsReshareOfTextPostAppMediaInIg { get; set; }

        [JsonProperty("integrity_review_decision", NullValueHandling = NullValueHandling.Ignore)]
        public string? IntegrityReviewDecision { get; set; }

        [JsonProperty("client_cache_key", NullValueHandling = NullValueHandling.Ignore)]
        public string? ClientCacheKey { get; set; }

        [JsonProperty("filter_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? FilterType { get; set; }

        [JsonProperty("is_visual_reply_commenter_notice_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsVisualReplyCommenterNoticeEnabled { get; set; }

        [JsonProperty("like_and_view_counts_disabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? LikeAndViewCountsDisabled { get; set; }

        [JsonProperty("has_privately_liked", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasPrivatelyLiked { get; set; }

        [JsonProperty("is_post_live_clips_media", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPostLiveClipsMedia { get; set; }

        [JsonProperty("is_quiet_post", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsQuietPost { get; set; }

        [JsonProperty("subtype_name_for_REST__", NullValueHandling = NullValueHandling.Ignore)]
        public string? SubtypeNameForRest { get; set; }

        [JsonProperty("taken_at", NullValueHandling = NullValueHandling.Ignore)]
        public int? TakenAt { get; set; }

        [JsonProperty("has_tagged_users", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasTaggedUsers { get; set; }

        [JsonProperty("photo_of_you", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PhotoOfYou { get; set; }

        [JsonProperty("can_see_insights_as_brand", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanSeeInsightsAsBrand { get; set; }

        [JsonProperty("media_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? MediaType { get; set; }

        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string? Code { get; set; }

        [JsonProperty("caption")]
        public Caption Caption { get; set; }

        [JsonProperty("fundraiser_tag")]
        public FundraiserTag FundraiserTag { get; set; }

        [JsonProperty("sharing_friction_info")]
        public SharingFrictionInfo SharingFrictionInfo { get; set; }

        [JsonProperty("timeline_pinned_user_ids")]
        public string?[] TimelinePinnedUserIds { get; set; }

        [JsonProperty("play_count")]
        public int PlayCount { get; set; }

        [JsonProperty("has_views_fetching")]
        public bool HasViewsFetching { get; set; }

        [JsonProperty("ig_play_count")]
        public int IgPlayCount { get; set; }

        [JsonProperty("original_media_has_visual_reply_media")]
        public bool OriginalMediaHasVisualReplyMedia { get; set; }

        [JsonProperty("creator_viewer_insights")]
        public string?[] CreatorViewerInsights { get; set; }

        [JsonProperty("display_uri")]
        public Uri DisplayUri { get; set; }

        [JsonProperty("fb_user_tags")]
        public FbUserTags FbUserTags { get; set; }

        [JsonProperty("coauthor_producers")]
        public string?[] CoauthorProducers { get; set; }

        [JsonProperty("coauthor_producer_can_see_organic_insights")]
        public bool CoauthorProducerCanSeeOrganicInsights { get; set; }

        [JsonProperty("invited_coauthor_producers")]
        public string?[] InvitedCoauthorProducers { get; set; }

        [JsonProperty("is_in_profile_grid")]
        public bool IsInProfileGrid { get; set; }

        [JsonProperty("profile_grid_control_enabled")]
        public bool ProfileGridControlEnabled { get; set; }

        [JsonProperty("media_cropping_info")]
        public MediaCroppingInfo MediaCroppingInfo { get; set; }

        [JsonProperty("user")]
        public MediaUser User { get; set; }

        [JsonProperty("image_versions2", NullValueHandling = NullValueHandling.Ignore)]
        public ImageVersions2 ImageVersions2 { get; set; }

        [JsonProperty("original_width")]
        public int OriginalWidth { get; set; }

        [JsonProperty("original_height")]
        public int OriginalHeight { get; set; }

        [JsonProperty("is_artist_pick", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsArtistPick { get; set; }

        [JsonProperty("media_reposter_bottomsheet_enabled")]
        public bool MediaReposterBottomsheetEnabled { get; set; }

        [JsonProperty("enable_media_notes_production")]
        public bool EnableMediaNotesProduction { get; set; }

        [JsonProperty("product_type")]
        public string? ProductType { get; set; }

        [JsonProperty("is_paid_partnership")]
        public bool IsPaidPartnership { get; set; }

        [JsonProperty("music_metadata")]
        public object MusicMetadata { get; set; }

        [JsonProperty("organic_tracking_token")]
        public string? OrganicTrackingToken { get; set; }

        [JsonProperty("is_third_party_downloads_eligible")]
        public bool IsThirdPartyDownloadsEligible { get; set; }

        [JsonProperty("ig_media_sharing_disabled")]
        public bool IgMediaSharingDisabled { get; set; }

        [JsonProperty("are_remixes_crosspostable")]
        public bool AreRemixesCrosspostable { get; set; }

        [JsonProperty("boost_unavailable_identifier")]
        public object BoostUnavailableIdentifier { get; set; }

        [JsonProperty("boost_unavailable_reason")]
        public object BoostUnavailableReason { get; set; }

        [JsonProperty("boost_unavailable_reason_v2")]
        public string?[] BoostUnavailableReasonV2 { get; set; }

        [JsonProperty("subscribe_cta_visible")]
        public bool SubscribeCtaVisible { get; set; }

        [JsonProperty("is_cutout_sticker_allowed")]
        public bool IsCutoutStickerAllowed { get; set; }

        [JsonProperty("cutout_sticker_info")]
        public string?[] CutoutStickerInfo { get; set; }

        [JsonProperty("avatar_stickers")]
        public string?[] AvatarStickers { get; set; }

        [JsonProperty("gen_ai_detection_method")]
        public GenAiDetectionMethod GenAiDetectionMethod { get; set; }

        [JsonProperty("fb_aggregated_like_count")]
        public int FbAggregatedLikeCount { get; set; }

        [JsonProperty("fb_aggregated_comment_count")]
        public int FbAggregatedCommentCount { get; set; }

        [JsonProperty("has_high_risk_gen_ai_inform_treatment")]
        public bool HasHighRiskGenAiInformTreatment { get; set; }

        [JsonProperty("open_carousel_show_follow_button")]
        public bool OpenCarouselShowFollowButton { get; set; }

        [JsonProperty("is_tagged_media_shared_to_viewer_profile_grid")]
        public bool IsTaggedMediaSharedToViewerProfileGrid { get; set; }

        [JsonProperty("should_show_author_pog_for_tagged_media_shared_to_profile_grid")]
        public bool ShouldShowAuthorPogForTaggedMediaSharedToProfileGrid { get; set; }

        [JsonProperty("is_social_ufi_disabled")]
        public bool IsSocialUfiDisabled { get; set; }

        [JsonProperty("is_eligible_for_meta_ai_share")]
        public bool IsEligibleForMetaAiShare { get; set; }

        [JsonProperty("meta_ai_suggested_prompts")]
        public string?[] MetaAiSuggestedPrompts { get; set; }

        [JsonProperty("can_reply")]
        public bool CanReply { get; set; }

        [JsonProperty("floating_context_items")]
        public string?[] FloatingContextItems { get; set; }

        [JsonProperty("is_eligible_content_for_post_roll_ad")]
        public bool IsEligibleContentForPostRollAd { get; set; }

        [JsonProperty("meta_ai_contextual_voice_data")]
        public MetaAiContextualVoiceData MetaAiContextualVoiceData { get; set; }

        [JsonProperty("related_ads_pivots_media_info")]
        public string? RelatedAdsPivotsMediaInfo { get; set; }

        [JsonProperty("is_open_to_public_submission")]
        public bool IsOpenToPublicSubmission { get; set; }

        [JsonProperty("hidden_likes_string_variant")]
        public int HiddenLikesStringVariant { get; set; }

        [JsonProperty("can_view_more_preview_comments")]
        public bool CanViewMorePreviewComments { get; set; }

        [JsonProperty("comment_count")]
        public int CommentCount { get; set; }

        [JsonProperty("hide_view_all_comment_entrypoint")]
        public bool HideViewAllCommentEntrypoint { get; set; }

        [JsonProperty("is_comments_gif_composer_enabled")]
        public bool IsCommentsGifComposerEnabled { get; set; }

        [JsonProperty("comment_inform_treatment")]
        public CommentInformTreatment CommentInformTreatment { get; set; }

        [JsonProperty("has_liked")]
        public bool HasLiked { get; set; }

        [JsonProperty("like_count")]
        public int LikeCount { get; set; }

        [JsonProperty("video_sticker_locales")]
        public string?[] VideoStickerLocales { get; set; }

        [JsonProperty("is_dash_eligible")]
        public int IsDashEligible { get; set; }

        [JsonProperty("video_dash_manifest")]
        public string? VideoDashManifest { get; set; }

        [JsonProperty("number_of_qualities")]
        public int NumberOfQualities { get; set; }

        [JsonProperty("video_versions")]
        public VideoVersion[] VideoVersions { get; set; }

        [JsonProperty("video_duration")]
        public double VideoDuration { get; set; }

        [JsonProperty("has_audio")]
        public bool HasAudio { get; set; }

        [JsonProperty("clips_tab_pinned_user_ids")]
        public int[] ClipsTabPinnedUserIds { get; set; }

        [JsonProperty("clips_metadata")]
        public ClipsMetadata ClipsMetadata { get; set; }

        [JsonProperty("can_viewer_save")]
        public bool CanViewerSave { get; set; }

        [JsonProperty("can_viewer_reshare")]
        public bool CanViewerReshare { get; set; }

        [JsonProperty("shop_routing_user_id")]
        public object ShopRoutingUserId { get; set; }

        [JsonProperty("is_organic_product_tagging_eligible")]
        public bool IsOrganicProductTaggingEligible { get; set; }

        [JsonProperty("igbio_product")]
        public object IgbioProduct { get; set; }

        [JsonProperty("product_suggestions")]
        public string?[] ProductSuggestions { get; set; }

        [JsonProperty("view_state_item_type")]
        public int ViewStateItemType { get; set; }

        [JsonProperty("logging_info_token")]
        public string? LoggingInfoToken { get; set; }

        [JsonProperty("is_reuse_allowed")]
        public bool IsReuseAllowed { get; set; }
    }

    public partial class Caption
    {
        [JsonProperty("bit_flags", NullValueHandling = NullValueHandling.Ignore)]
        public int? BitFlags { get; set; }

        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public int? CreatedAt { get; set; }

        [JsonProperty("created_at_utc", NullValueHandling = NullValueHandling.Ignore)]
        public int? CreatedAtUtc { get; set; }

        [JsonProperty("did_report_as_spam", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DidReportAsSpam { get; set; }

        [JsonProperty("is_ranked_comment", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsRankedComment { get; set; }

        [JsonProperty("pk", NullValueHandling = NullValueHandling.Ignore)]
        public string? Pk { get; set; }

        [JsonProperty("share_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShareEnabled { get; set; }

        [JsonProperty("content_type", NullValueHandling = NullValueHandling.Ignore)]
        public string? ContentType { get; set; }

        [JsonProperty("media_id", NullValueHandling = NullValueHandling.Ignore)]
        public string? MediaId { get; set; }

        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string? Status { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; }

        [JsonProperty("user_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? UserId { get; set; }

        [JsonProperty("strong_id__", NullValueHandling = NullValueHandling.Ignore)]
        public string? StrongId { get; set; }

        [JsonProperty("text")]
        public string? Text { get; set; }

        [JsonProperty("user")]
        public IgArtistClass User { get; set; }

        [JsonProperty("is_covered")]
        public bool IsCovered { get; set; }

        [JsonProperty("private_reply_status")]
        public int PrivateReplyStatus { get; set; }
    }

    public partial class IgArtistClass
    {
        [JsonProperty("pk")]
        public string? Pk { get; set; }

        [JsonProperty("pk_id")]
        public string? PkId { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("full_name")]
        public string? FullName { get; set; }

        [JsonProperty("is_private", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPrivate { get; set; }

        [JsonProperty("is_unpublished", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsUnpublished { get; set; }

        [JsonProperty("strong_id__", NullValueHandling = NullValueHandling.Ignore)]
        public string? StrongId { get; set; }

        [JsonProperty("fbid_v2", NullValueHandling = NullValueHandling.Ignore)]
        public string? FbidV2 { get; set; }

        [JsonProperty("username")]
        public string? Username { get; set; }

        [JsonProperty("is_verified")]
        public bool IsVerified { get; set; }

        [JsonProperty("profile_pic_id")]
        public string? ProfilePicId { get; set; }
    }

    public partial class ClipsMetadata
    {
        [JsonProperty("clips_creation_entry_point")]
        public string? ClipsCreationEntryPoint { get; set; }

        [JsonProperty("featured_label")]
        public object FeaturedLabel { get; set; }

        [JsonProperty("is_public_chat_welcome_video")]
        public bool IsPublicChatWelcomeVideo { get; set; }

        [JsonProperty("professional_clips_upsell_type")]
        public int ProfessionalClipsUpsellType { get; set; }

        [JsonProperty("show_tips")]
        public object ShowTips { get; set; }

        [JsonProperty("achievements_info")]
        public AchievementsInfo AchievementsInfo { get; set; }

        [JsonProperty("additional_audio_info")]
        public AdditionalAudioInfo AdditionalAudioInfo { get; set; }

        [JsonProperty("asset_recommendation_info")]
        public object AssetRecommendationInfo { get; set; }

        [JsonProperty("audio_ranking_info")]
        public AudioRankingInfo AudioRankingInfo { get; set; }

        [JsonProperty("audio_type")]
        public string? AudioType { get; set; }

        [JsonProperty("branded_content_tag_info")]
        public BrandedContentTagInfo BrandedContentTagInfo { get; set; }

        [JsonProperty("breaking_content_info")]
        public object BreakingContentInfo { get; set; }

        [JsonProperty("breaking_creator_info")]
        public object BreakingCreatorInfo { get; set; }

        [JsonProperty("challenge_info")]
        public object ChallengeInfo { get; set; }

        [JsonProperty("content_appreciation_info")]
        public ContentAppreciationInfo ContentAppreciationInfo { get; set; }

        [JsonProperty("contextual_highlight_info")]
        public object ContextualHighlightInfo { get; set; }

        [JsonProperty("cutout_sticker_info")]
        public string?[] CutoutStickerInfo { get; set; }

        [JsonProperty("disable_use_in_clips_client_cache")]
        public bool DisableUseInClipsClientCache { get; set; }

        [JsonProperty("external_media_info")]
        public object ExternalMediaInfo { get; set; }

        [JsonProperty("is_fan_club_promo_video")]
        public object IsFanClubPromoVideo { get; set; }

        [JsonProperty("is_shared_to_fb")]
        public bool IsSharedToFb { get; set; }

        [JsonProperty("mashup_info")]
        public MashupInfo MashupInfo { get; set; }

        [JsonProperty("merchandising_pill_info")]
        public object MerchandisingPillInfo { get; set; }

        [JsonProperty("music_canonical_id")]
        public string? MusicCanonicalId { get; set; }

        [JsonProperty("music_info")]
        public object MusicInfo { get; set; }

        [JsonProperty("nux_info")]
        public object NuxInfo { get; set; }

        [JsonProperty("original_sound_info")]
        public OriginalSoundInfo OriginalSoundInfo { get; set; }

        [JsonProperty("originality_info")]
        public object OriginalityInfo { get; set; }

        [JsonProperty("reels_on_the_rise_info")]
        public object ReelsOnTheRiseInfo { get; set; }

        [JsonProperty("reusable_text_attribute_string")]
        public object ReusableTextAttributeString { get; set; }

        [JsonProperty("reusable_text_info")]
        public object ReusableTextInfo { get; set; }

        [JsonProperty("shopping_info")]
        public object ShoppingInfo { get; set; }

        [JsonProperty("show_achievements")]
        public bool ShowAchievements { get; set; }

        [JsonProperty("template_info")]
        public object TemplateInfo { get; set; }

        [JsonProperty("may_have_template_info")]
        public object MayHaveTemplateInfo { get; set; }

        [JsonProperty("viewer_interaction_settings")]
        public object ViewerInteractionSettings { get; set; }
    }

    public partial class AchievementsInfo
    {
        [JsonProperty("num_earned_achievements")]
        public object NumEarnedAchievements { get; set; }

        [JsonProperty("show_achievements")]
        public bool ShowAchievements { get; set; }
    }

    public partial class AdditionalAudioInfo
    {
        [JsonProperty("additional_audio_username")]
        public object AdditionalAudioUsername { get; set; }

        [JsonProperty("audio_reattribution_info")]
        public AudioReattributionInfo AudioReattributionInfo { get; set; }
    }

    public partial class AudioReattributionInfo
    {
        [JsonProperty("should_allow_restore")]
        public bool ShouldAllowRestore { get; set; }
    }

    public partial class AudioRankingInfo
    {
        [JsonProperty("best_audio_cluster_id")]
        public string? BestAudioClusterId { get; set; }
    }

    public partial class BrandedContentTagInfo
    {
        [JsonProperty("can_add_tag")]
        public bool CanAddTag { get; set; }
    }

    public partial class ContentAppreciationInfo
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("entry_point_container")]
        public object EntryPointContainer { get; set; }
    }

    public partial class MashupInfo
    {
        [JsonProperty("can_toggle_mashups_allowed")]
        public bool CanToggleMashupsAllowed { get; set; }

        [JsonProperty("formatted_mashups_count")]
        public object FormattedMashupsCount { get; set; }

        [JsonProperty("has_been_mashed_up")]
        public bool HasBeenMashedUp { get; set; }

        [JsonProperty("has_nonmimicable_additional_audio")]
        public bool HasNonmimicableAdditionalAudio { get; set; }

        [JsonProperty("is_creator_requesting_mashup")]
        public bool IsCreatorRequestingMashup { get; set; }

        [JsonProperty("is_light_weight_check")]
        public bool IsLightWeightCheck { get; set; }

        [JsonProperty("is_light_weight_reuse_allowed_check")]
        public bool IsLightWeightReuseAllowedCheck { get; set; }

        [JsonProperty("is_pivot_page_available")]
        public bool IsPivotPageAvailable { get; set; }

        [JsonProperty("is_reuse_allowed")]
        public bool IsReuseAllowed { get; set; }

        [JsonProperty("mashup_type")]
        public object MashupType { get; set; }

        [JsonProperty("mashups_allowed")]
        public bool MashupsAllowed { get; set; }

        [JsonProperty("non_privacy_filtered_mashups_media_count")]
        public int NonPrivacyFilteredMashupsMediaCount { get; set; }

        [JsonProperty("privacy_filtered_mashups_media_count")]
        public object PrivacyFilteredMashupsMediaCount { get; set; }

        [JsonProperty("original_media")]
        public object OriginalMedia { get; set; }
    }

    public partial class OriginalSoundInfo
    {
        [JsonProperty("allow_creator_to_rename")]
        public bool AllowCreatorToRename { get; set; }

        [JsonProperty("audio_asset_id")]
        public string? AudioAssetId { get; set; }

        [JsonProperty("attributed_custom_audio_asset_id")]
        public object AttributedCustomAudioAssetId { get; set; }

        [JsonProperty("can_remix_be_shared_to_fb")]
        public bool CanRemixBeSharedToFb { get; set; }

        [JsonProperty("can_remix_be_shared_to_fb_expansion")]
        public bool CanRemixBeSharedToFbExpansion { get; set; }

        [JsonProperty("dash_manifest")]
        public string? DashManifest { get; set; }

        [JsonProperty("duration_in_ms")]
        public int DurationInMs { get; set; }

        [JsonProperty("formatted_clips_media_count")]
        public object FormattedClipsMediaCount { get; set; }

        [JsonProperty("hide_remixing")]
        public bool HideRemixing { get; set; }

        [JsonProperty("is_audio_automatically_attributed")]
        public bool IsAudioAutomaticallyAttributed { get; set; }

        [JsonProperty("is_eligible_for_audio_effects")]
        public bool IsEligibleForAudioEffects { get; set; }

        [JsonProperty("is_eligible_for_vinyl_sticker")]
        public bool IsEligibleForVinylSticker { get; set; }

        [JsonProperty("is_explicit")]
        public bool IsExplicit { get; set; }

        [JsonProperty("is_original_audio_download_eligible")]
        public bool IsOriginalAudioDownloadEligible { get; set; }

        [JsonProperty("is_reuse_disabled")]
        public bool IsReuseDisabled { get; set; }

        [JsonProperty("is_xpost_from_fb")]
        public bool IsXpostFromFb { get; set; }

        [JsonProperty("music_canonical_id")]
        public object MusicCanonicalId { get; set; }

        [JsonProperty("oa_owner_is_music_artist")]
        public bool OaOwnerIsMusicArtist { get; set; }

        [JsonProperty("original_audio_subtype")]
        public string? OriginalAudioSubtype { get; set; }

        [JsonProperty("original_audio_title")]
        public string? OriginalAudioTitle { get; set; }

        [JsonProperty("original_media_id")]
        public string? OriginalMediaId { get; set; }

        [JsonProperty("progressive_download_url")]
        public Uri ProgressiveDownloadUrl { get; set; }

        [JsonProperty("should_mute_audio")]
        public bool ShouldMuteAudio { get; set; }

        [JsonProperty("time_created")]
        public int TimeCreated { get; set; }

        [JsonProperty("trend_rank")]
        public object TrendRank { get; set; }

        [JsonProperty("previous_trend_rank")]
        public object PreviousTrendRank { get; set; }

        [JsonProperty("overlap_duration_in_ms")]
        public object OverlapDurationInMs { get; set; }

        [JsonProperty("audio_asset_start_time_in_ms")]
        public object AudioAssetStartTimeInMs { get; set; }

        [JsonProperty("ig_artist")]
        public IgArtistClass IgArtist { get; set; }

        [JsonProperty("audio_filter_infos")]
        public string?[] AudioFilterInfos { get; set; }

        [JsonProperty("audio_parts")]
        public string?[] AudioParts { get; set; }

        [JsonProperty("audio_parts_by_filter")]
        public string?[] AudioPartsByFilter { get; set; }

        [JsonProperty("consumption_info")]
        public ConsumptionInfo ConsumptionInfo { get; set; }

        [JsonProperty("xpost_fb_creator_info")]
        public object XpostFbCreatorInfo { get; set; }

        [JsonProperty("fb_downstream_use_xpost_metadata")]
        public FbDownstreamUseXpostMetadata FbDownstreamUseXpostMetadata { get; set; }
    }

    public partial class ConsumptionInfo
    {
        [JsonProperty("display_media_id")]
        public object DisplayMediaId { get; set; }

        [JsonProperty("is_bookmarked")]
        public bool IsBookmarked { get; set; }

        [JsonProperty("is_trending_in_clips")]
        public bool IsTrendingInClips { get; set; }

        [JsonProperty("should_mute_audio_reason")]
        public string? ShouldMuteAudioReason { get; set; }

        [JsonProperty("should_mute_audio_reason_type")]
        public object ShouldMuteAudioReasonType { get; set; }

        [JsonProperty("user_notes")]
        public object UserNotes { get; set; }
    }

    public partial class FbDownstreamUseXpostMetadata
    {
        [JsonProperty("downstream_use_xpost_deny_reason")]
        public string? DownstreamUseXpostDenyReason { get; set; }
    }

    public partial class CommentInformTreatment
    {
        [JsonProperty("action_type")]
        public object ActionType { get; set; }

        [JsonProperty("should_have_inform_treatment")]
        public bool ShouldHaveInformTreatment { get; set; }

        [JsonProperty("text")]
        public string? Text { get; set; }

        [JsonProperty("url")]
        public object Url { get; set; }
    }

    public partial class FbUserTags
    {
        [JsonProperty("in")]
        public string?[] In { get; set; }
    }

    public partial class FundraiserTag
    {
        [JsonProperty("has_standalone_fundraiser")]
        public bool HasStandaloneFundraiser { get; set; }
    }

    public partial class GenAiDetectionMethod
    {
        [JsonProperty("detection_method")]
        public string? DetectionMethod { get; set; }
    }

    public partial class ImageVersions2
    {
        [JsonProperty("additional_candidates")]
        public AdditionalCandidates AdditionalCandidates { get; set; }

        [JsonProperty("candidates")]
        public FirstFrame[] Candidates { get; set; }
    }

    public partial class AdditionalCandidates
    {
        [JsonProperty("first_frame")]
        public FirstFrame FirstFrame { get; set; }

        [JsonProperty("igtv_first_frame")]
        public FirstFrame IgtvFirstFrame { get; set; }

        [JsonProperty("smart_frame")]
        public object SmartFrame { get; set; }
    }

    public partial class FirstFrame
    {
        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("scans_profile")]
        public string? ScansProfile { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }
    }

    public partial class MediaCroppingInfo
    {
        [JsonProperty("square_crop")]
        public SquareCrop SquareCrop { get; set; }
    }

    public partial class SquareCrop
    {
        [JsonProperty("crop_left")]
        public int CropLeft { get; set; }

        [JsonProperty("crop_right")]
        public int CropRight { get; set; }

        [JsonProperty("crop_top")]
        public int CropTop { get; set; }

        [JsonProperty("crop_bottom")]
        public int CropBottom { get; set; }
    }

    public partial class MetaAiContextualVoiceData
    {
        [JsonProperty("is_eligible")]
        public bool IsEligible { get; set; }

        [JsonProperty("eligibility_result_reason")]
        public string? EligibilityResultReason { get; set; }
    }

    public partial class SharingFrictionInfo
    {
        [JsonProperty("bloks_app_url")]
        public object BloksAppUrl { get; set; }

        [JsonProperty("should_have_sharing_friction")]
        public bool ShouldHaveSharingFriction { get; set; }

        [JsonProperty("sharing_friction_payload")]
        public object SharingFrictionPayload { get; set; }
    }

    public partial class MediaUser
    {
        [JsonProperty("fbid_v2")]
        public string? FbidV2 { get; set; }

        [JsonProperty("feed_post_reshare_disabled")]
        public bool FeedPostReshareDisabled { get; set; }

        [JsonProperty("full_name")]
        public string? FullName { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("is_private")]
        public bool IsPrivate { get; set; }

        [JsonProperty("is_unpublished")]
        public bool IsUnpublished { get; set; }

        [JsonProperty("pk")]
        public int Pk { get; set; }

        [JsonProperty("pk_id")]
        public int PkId { get; set; }

        [JsonProperty("show_account_transparency_details")]
        public bool ShowAccountTransparencyDetails { get; set; }

        [JsonProperty("strong_id__")]
        public int StrongId { get; set; }

        [JsonProperty("third_party_downloads_enabled")]
        public int ThirdPartyDownloadsEnabled { get; set; }

        [JsonProperty("account_type")]
        public int AccountType { get; set; }

        [JsonProperty("account_badges")]
        public string?[] AccountBadges { get; set; }

        [JsonProperty("fan_club_info")]
        public FanClubInfo FanClubInfo { get; set; }

        [JsonProperty("has_anonymous_profile_picture")]
        public bool HasAnonymousProfilePicture { get; set; }

        [JsonProperty("is_verified")]
        public bool IsVerified { get; set; }

        [JsonProperty("profile_pic_id")]
        public string? ProfilePicId { get; set; }

        [JsonProperty("transparency_product_enabled")]
        public bool TransparencyProductEnabled { get; set; }

        [JsonProperty("username")]
        public string? Username { get; set; }

        [JsonProperty("eligible_for_text_app_activation_badge")]
        public bool EligibleForTextAppActivationBadge { get; set; }
    }

    public partial class FanClubInfo
    {
        [JsonProperty("autosave_to_exclusive_highlight")]
        public object AutosaveToExclusiveHighlight { get; set; }

        [JsonProperty("connected_member_count")]
        public object ConnectedMemberCount { get; set; }

        [JsonProperty("fan_club_id")]
        public object FanClubId { get; set; }

        [JsonProperty("fan_club_name")]
        public object FanClubName { get; set; }

        [JsonProperty("has_created_ssc")]
        public object HasCreatedSsc { get; set; }

        [JsonProperty("has_enough_subscribers_for_ssc")]
        public object HasEnoughSubscribersForSsc { get; set; }

        [JsonProperty("is_fan_club_gifting_eligible")]
        public object IsFanClubGiftingEligible { get; set; }

        [JsonProperty("is_fan_club_referral_eligible")]
        public object IsFanClubReferralEligible { get; set; }

        [JsonProperty("is_free_trial_eligible")]
        public object IsFreeTrialEligible { get; set; }

        [JsonProperty("largest_public_bc_id")]
        public object LargestPublicBcId { get; set; }

        [JsonProperty("subscriber_count")]
        public object SubscriberCount { get; set; }

        [JsonProperty("fan_consideration_page_revamp_eligiblity")]
        public object FanConsiderationPageRevampEligiblity { get; set; }
    }

    public partial class VideoVersion
    {
        [JsonProperty("bandwidth")]
        public object Bandwidth { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }
    }

    public partial class PagingInfo
    {
        [JsonProperty("more_available")]
        public bool MoreAvailable { get; set; }
    }

}
