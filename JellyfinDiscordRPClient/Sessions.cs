namespace JellyfinDiscordRPClient
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Sessions
    {
        [JsonProperty("PlayState")]
        public PlayState PlayState { get; set; }

        [JsonProperty("AdditionalUsers")]
        public object[] AdditionalUsers { get; set; }

        [JsonProperty("Capabilities")]
        public Capabilities Capabilities { get; set; }

        [JsonProperty("RemoteEndPoint")]
        public string RemoteEndPoint { get; set; }

        [JsonProperty("PlayableMediaTypes")]
        public MediaTypeElement[] PlayableMediaTypes { get; set; }

        [JsonProperty("Id")]
        public string Id { get; set; }

        [JsonProperty("Client")]
        public string Client { get; set; }

        [JsonProperty("LastActivityDate")]
        public DateTimeOffset LastActivityDate { get; set; }

        [JsonProperty("LastPlaybackCheckIn")]
        public DateTimeOffset LastPlaybackCheckIn { get; set; }

        [JsonProperty("DeviceName")]
        public string DeviceName { get; set; }

        [JsonProperty("DeviceId")]
        public string DeviceId { get; set; }

        [JsonProperty("ApplicationVersion")]
        public string ApplicationVersion { get; set; }

        [JsonProperty("IsActive")]
        public bool IsActive { get; set; }

        [JsonProperty("SupportsMediaControl")]
        public bool SupportsMediaControl { get; set; }

        [JsonProperty("SupportsRemoteControl")]
        public bool SupportsRemoteControl { get; set; }

        [JsonProperty("HasCustomDeviceName")]
        public bool HasCustomDeviceName { get; set; }

        [JsonProperty("ServerId")]
        public string ServerId { get; set; }

        [JsonProperty("SupportedCommands")]
        public string[] SupportedCommands { get; set; }

        [JsonProperty("UserId", NullValueHandling = NullValueHandling.Ignore)]
        public string UserId { get; set; }

        [JsonProperty("UserName", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        [JsonProperty("NowPlayingItem", NullValueHandling = NullValueHandling.Ignore)]
        public NowPlayingItem NowPlayingItem { get; set; }

        [JsonProperty("FullNowPlayingItem", NullValueHandling = NullValueHandling.Ignore)]
        public FullNowPlayingItem FullNowPlayingItem { get; set; }

        [JsonProperty("NowPlayingQueue", NullValueHandling = NullValueHandling.Ignore)]
        public NowPlayingQueue[] NowPlayingQueue { get; set; }

        [JsonProperty("PlaylistItemId", NullValueHandling = NullValueHandling.Ignore)]
        public string PlaylistItemId { get; set; }

        [JsonProperty("UserPrimaryImageTag", NullValueHandling = NullValueHandling.Ignore)]
        public string UserPrimaryImageTag { get; set; }
    }

    public partial class Capabilities
    {
        [JsonProperty("PlayableMediaTypes")]
        public MediaTypeElement[] PlayableMediaTypes { get; set; }

        [JsonProperty("SupportedCommands")]
        public string[] SupportedCommands { get; set; }

        [JsonProperty("SupportsMediaControl")]
        public bool SupportsMediaControl { get; set; }

        [JsonProperty("SupportsContentUploading")]
        public bool SupportsContentUploading { get; set; }

        [JsonProperty("SupportsPersistentIdentifier")]
        public bool SupportsPersistentIdentifier { get; set; }

        [JsonProperty("SupportsSync")]
        public bool SupportsSync { get; set; }

        [JsonProperty("Id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("DeviceProfile", NullValueHandling = NullValueHandling.Ignore)]
        public DeviceProfile DeviceProfile { get; set; }
    }

    public partial class DeviceProfile
    {
        [JsonProperty("EnableAlbumArtInDidl")]
        public bool EnableAlbumArtInDidl { get; set; }

        [JsonProperty("EnableSingleAlbumArtLimit")]
        public bool EnableSingleAlbumArtLimit { get; set; }

        [JsonProperty("EnableSingleSubtitleLimit")]
        public bool EnableSingleSubtitleLimit { get; set; }

        [JsonProperty("SupportedMediaTypes")]
        public string SupportedMediaTypes { get; set; }

        [JsonProperty("MaxAlbumArtWidth")]
        public long MaxAlbumArtWidth { get; set; }

        [JsonProperty("MaxAlbumArtHeight")]
        public long MaxAlbumArtHeight { get; set; }

        [JsonProperty("MaxStreamingBitrate")]
        public long MaxStreamingBitrate { get; set; }

        [JsonProperty("MaxStaticBitrate")]
        public long MaxStaticBitrate { get; set; }

        [JsonProperty("MusicStreamingTranscodingBitrate")]
        public long MusicStreamingTranscodingBitrate { get; set; }

        [JsonProperty("MaxStaticMusicBitrate")]
        public long MaxStaticMusicBitrate { get; set; }

        [JsonProperty("TimelineOffsetSeconds")]
        public long TimelineOffsetSeconds { get; set; }

        [JsonProperty("RequiresPlainVideoItems")]
        public bool RequiresPlainVideoItems { get; set; }

        [JsonProperty("RequiresPlainFolders")]
        public bool RequiresPlainFolders { get; set; }

        [JsonProperty("EnableMSMediaReceiverRegistrar")]
        public bool EnableMsMediaReceiverRegistrar { get; set; }

        [JsonProperty("IgnoreTranscodeByteRangeRequests")]
        public bool IgnoreTranscodeByteRangeRequests { get; set; }

        [JsonProperty("XmlRootAttributes")]
        public object[] XmlRootAttributes { get; set; }

        [JsonProperty("DirectPlayProfiles")]
        public DirectPlayProfile[] DirectPlayProfiles { get; set; }

        [JsonProperty("TranscodingProfiles")]
        public TranscodingProfile[] TranscodingProfiles { get; set; }

        [JsonProperty("ContainerProfiles")]
        public object[] ContainerProfiles { get; set; }

        [JsonProperty("CodecProfiles")]
        public CodecProfile[] CodecProfiles { get; set; }

        [JsonProperty("ResponseProfiles")]
        public ResponseProfile[] ResponseProfiles { get; set; }

        [JsonProperty("SubtitleProfiles")]
        public SubtitleProfile[] SubtitleProfiles { get; set; }
    }

    public partial class CodecProfile
    {
        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("Conditions")]
        public ConditionElement[] Conditions { get; set; }

        [JsonProperty("ApplyConditions")]
        public object[] ApplyConditions { get; set; }

        [JsonProperty("Codec", NullValueHandling = NullValueHandling.Ignore)]
        public string Codec { get; set; }
    }

    public partial class ConditionElement
    {
        [JsonProperty("Condition")]
        public ConditionEnum Condition { get; set; }

        [JsonProperty("Property")]
        public string Property { get; set; }

        [JsonProperty("Value")]
        public string Value { get; set; }

        [JsonProperty("IsRequired")]
        public bool IsRequired { get; set; }
    }

    public partial class DirectPlayProfile
    {
        [JsonProperty("Container")]
        public string Container { get; set; }

        [JsonProperty("AudioCodec", NullValueHandling = NullValueHandling.Ignore)]
        public string AudioCodec { get; set; }

        [JsonProperty("VideoCodec", NullValueHandling = NullValueHandling.Ignore)]
        public string VideoCodec { get; set; }

        [JsonProperty("Type")]
        public MediaTypeElement Type { get; set; }
    }

    public partial class ResponseProfile
    {
        [JsonProperty("Container")]
        public string Container { get; set; }

        [JsonProperty("Type")]
        public MediaTypeElement Type { get; set; }

        [JsonProperty("MimeType")]
        public string MimeType { get; set; }

        [JsonProperty("Conditions")]
        public object[] Conditions { get; set; }
    }

    public partial class SubtitleProfile
    {
        [JsonProperty("Format")]
        public string Format { get; set; }

        [JsonProperty("Method")]
        public string Method { get; set; }
    }

    public partial class TranscodingProfile
    {
        [JsonProperty("Container")]
        public string Container { get; set; }

        [JsonProperty("Type")]
        public MediaTypeElement Type { get; set; }

        [JsonProperty("AudioCodec")]
        public string AudioCodec { get; set; }

        [JsonProperty("Protocol")]
        public Protocol Protocol { get; set; }

        [JsonProperty("EstimateContentLength")]
        public bool EstimateContentLength { get; set; }

        [JsonProperty("EnableMpegtsM2TsMode")]
        public bool EnableMpegtsM2TsMode { get; set; }

        [JsonProperty("TranscodeSeekInfo")]
        public TranscodeSeekInfo TranscodeSeekInfo { get; set; }

        [JsonProperty("CopyTimestamps")]
        public bool CopyTimestamps { get; set; }

        [JsonProperty("Context")]
        public Context Context { get; set; }

        [JsonProperty("EnableSubtitlesInManifest")]
        public bool EnableSubtitlesInManifest { get; set; }

        [JsonProperty("MaxAudioChannels", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? MaxAudioChannels { get; set; }

        [JsonProperty("MinSegments")]
        public long MinSegments { get; set; }

        [JsonProperty("SegmentLength")]
        public long SegmentLength { get; set; }

        [JsonProperty("BreakOnNonKeyFrames")]
        public bool BreakOnNonKeyFrames { get; set; }

        [JsonProperty("VideoCodec", NullValueHandling = NullValueHandling.Ignore)]
        public string VideoCodec { get; set; }
    }

    public partial class FullNowPlayingItem
    {
        [JsonProperty("LocalTrailerIds")]
        public object[] LocalTrailerIds { get; set; }

        [JsonProperty("RemoteTrailerIds")]
        public object[] RemoteTrailerIds { get; set; }

        [JsonProperty("AdditionalParts")]
        public object[] AdditionalParts { get; set; }

        [JsonProperty("LocalAlternateVersions")]
        public object[] LocalAlternateVersions { get; set; }

        [JsonProperty("LinkedAlternateVersions")]
        public object[] LinkedAlternateVersions { get; set; }

        [JsonProperty("SubtitleFiles")]
        public object[] SubtitleFiles { get; set; }

        [JsonProperty("HasSubtitles")]
        public bool HasSubtitles { get; set; }

        [JsonProperty("IsPlaceHolder")]
        public bool IsPlaceHolder { get; set; }

        [JsonProperty("DefaultVideoStreamIndex")]
        public long DefaultVideoStreamIndex { get; set; }

        [JsonProperty("VideoType")]
        public string VideoType { get; set; }

        [JsonProperty("Size")]
        public long Size { get; set; }

        [JsonProperty("Container")]
        public string Container { get; set; }

        [JsonProperty("DateLastSaved")]
        public DateTimeOffset DateLastSaved { get; set; }

        [JsonProperty("RemoteTrailers")]
        public RemoteTrailer[] RemoteTrailers { get; set; }

        [JsonProperty("IsHD")]
        public bool IsHd { get; set; }

        [JsonProperty("IsShortcut")]
        public bool IsShortcut { get; set; }

        [JsonProperty("Width")]
        public long Width { get; set; }

        [JsonProperty("Height")]
        public long Height { get; set; }

        [JsonProperty("ExtraIds")]
        public object[] ExtraIds { get; set; }

        [JsonProperty("SupportsExternalTransfer")]
        public bool SupportsExternalTransfer { get; set; }

        [JsonProperty("SpecialFeatureIds", NullValueHandling = NullValueHandling.Ignore)]
        public object[] SpecialFeatureIds { get; set; }
    }

    public partial class RemoteTrailer
    {
        [JsonProperty("Url")]
        public Uri Url { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }
    }

    public partial class NowPlayingItem
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("ServerId")]
        public string ServerId { get; set; }

        [JsonProperty("Id")]
        public string Id { get; set; }

        [JsonProperty("DateCreated")]
        public DateTimeOffset DateCreated { get; set; }

        [JsonProperty("Container")]
        public string Container { get; set; }

        [JsonProperty("PremiereDate")]
        public DateTimeOffset PremiereDate { get; set; }

        [JsonProperty("ExternalUrls")]
        public RemoteTrailer[] ExternalUrls { get; set; }

        [JsonProperty("Path")]
        public string Path { get; set; }

        [JsonProperty("EnableMediaSourceDisplay")]
        public bool EnableMediaSourceDisplay { get; set; }

        [JsonProperty("Overview")]
        public string Overview { get; set; }

        [JsonProperty("Taglines")]
        public object[] Taglines { get; set; }

        [JsonProperty("Genres")]
        public object[] Genres { get; set; }

        [JsonProperty("CommunityRating")]
        public double CommunityRating { get; set; }

        [JsonProperty("RunTimeTicks")]
        public long RunTimeTicks { get; set; }

        [JsonProperty("ProductionYear")]
        public long ProductionYear { get; set; }

        [JsonProperty("IndexNumber")]
        public long IndexNumber { get; set; }

        [JsonProperty("ParentIndexNumber")]
        public long ParentIndexNumber { get; set; }

        [JsonProperty("ProviderIds")]
        public ProviderIds ProviderIds { get; set; }

        [JsonProperty("IsFolder")]
        public bool IsFolder { get; set; }

        [JsonProperty("ParentId")]
        public string ParentId { get; set; }

        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("Studios")]
        public object[] Studios { get; set; }

        [JsonProperty("GenreItems")]
        public object[] GenreItems { get; set; }

        [JsonProperty("ParentBackdropItemId")]
        public string ParentBackdropItemId { get; set; }

        [JsonProperty("ParentBackdropImageTags")]
        public string[] ParentBackdropImageTags { get; set; }

        [JsonProperty("LocalTrailerCount")]
        public long LocalTrailerCount { get; set; }

        [JsonProperty("SeriesName")]
        public string SeriesName { get; set; }

        [JsonProperty("SeriesId")]
        public string SeriesId { get; set; }

        [JsonProperty("SeasonId")]
        public string SeasonId { get; set; }

        [JsonProperty("SpecialFeatureCount")]
        public long SpecialFeatureCount { get; set; }

        [JsonProperty("PrimaryImageAspectRatio")]
        public double PrimaryImageAspectRatio { get; set; }

        [JsonProperty("SeasonName")]
        public string SeasonName { get; set; }

        [JsonProperty("MediaStreams")]
        public MediaStream[] MediaStreams { get; set; }

        [JsonProperty("VideoType")]
        public string VideoType { get; set; }

        [JsonProperty("ImageTags")]
        public ImageTags ImageTags { get; set; }

        [JsonProperty("BackdropImageTags")]
        public object[] BackdropImageTags { get; set; }

        [JsonProperty("ScreenshotImageTags")]
        public object[] ScreenshotImageTags { get; set; }

        [JsonProperty("ImageBlurHashes")]
        public ImageBlurHashes ImageBlurHashes { get; set; }

        [JsonProperty("SeriesStudio")]
        public string SeriesStudio { get; set; }

        [JsonProperty("Chapters")]
        public Chapter[] Chapters { get; set; }

        [JsonProperty("LocationType")]
        public string LocationType { get; set; }

        [JsonProperty("MediaType")]
        public MediaTypeElement MediaType { get; set; }

        [JsonProperty("Width")]
        public long Width { get; set; }

        [JsonProperty("Height")]
        public long Height { get; set; }
    }

    public partial class Chapter
    {
        [JsonProperty("StartPositionTicks")]
        public long StartPositionTicks { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("ImagePath")]
        public string ImagePath { get; set; }

        [JsonProperty("ImageDateModified")]
        public DateTimeOffset ImageDateModified { get; set; }

        [JsonProperty("ImageTag")]
        public string ImageTag { get; set; }
    }

    public partial class ImageBlurHashes
    {
        [JsonProperty("Primary")]
        public Primary Primary { get; set; }

        [JsonProperty("Backdrop")]
        public Backdrop Backdrop { get; set; }
    }

    public partial class Backdrop
    {
        [JsonProperty("897da1a9dfec715916bac77a644f638e")]
        public string The897Da1A9Dfec715916Bac77A644F638E { get; set; }
    }

    public partial class Primary
    {
        [JsonProperty("3fa61180f56dcede2aa6a7c90007d8eb")]
        public string The3Fa61180F56Dcede2Aa6A7C90007D8Eb { get; set; }
    }

    public partial class ImageTags
    {
        [JsonProperty("Primary")]
        public string Primary { get; set; }
    }

    public partial class MediaStream
    {
        [JsonProperty("Codec")]
        public string Codec { get; set; }

        [JsonProperty("ColorTransfer", NullValueHandling = NullValueHandling.Ignore)]
        public string ColorTransfer { get; set; }

        [JsonProperty("ColorPrimaries", NullValueHandling = NullValueHandling.Ignore)]
        public string ColorPrimaries { get; set; }

        [JsonProperty("TimeBase")]
        public string TimeBase { get; set; }

        [JsonProperty("CodecTimeBase")]
        public string CodecTimeBase { get; set; }

        [JsonProperty("VideoRange", NullValueHandling = NullValueHandling.Ignore)]
        public string VideoRange { get; set; }

        [JsonProperty("DisplayTitle")]
        public string DisplayTitle { get; set; }

        [JsonProperty("NalLengthSize", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? NalLengthSize { get; set; }

        [JsonProperty("IsInterlaced")]
        public bool IsInterlaced { get; set; }

        [JsonProperty("IsAVC", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAvc { get; set; }

        [JsonProperty("BitRate", NullValueHandling = NullValueHandling.Ignore)]
        public long? BitRate { get; set; }

        [JsonProperty("BitDepth", NullValueHandling = NullValueHandling.Ignore)]
        public long? BitDepth { get; set; }

        [JsonProperty("RefFrames", NullValueHandling = NullValueHandling.Ignore)]
        public long? RefFrames { get; set; }

        [JsonProperty("IsDefault")]
        public bool IsDefault { get; set; }

        [JsonProperty("IsForced")]
        public bool IsForced { get; set; }

        [JsonProperty("Height", NullValueHandling = NullValueHandling.Ignore)]
        public long? Height { get; set; }

        [JsonProperty("Width", NullValueHandling = NullValueHandling.Ignore)]
        public long? Width { get; set; }

        [JsonProperty("AverageFrameRate", NullValueHandling = NullValueHandling.Ignore)]
        public double? AverageFrameRate { get; set; }

        [JsonProperty("RealFrameRate", NullValueHandling = NullValueHandling.Ignore)]
        public double? RealFrameRate { get; set; }

        [JsonProperty("Profile", NullValueHandling = NullValueHandling.Ignore)]
        public string Profile { get; set; }

        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("AspectRatio", NullValueHandling = NullValueHandling.Ignore)]
        public string AspectRatio { get; set; }

        [JsonProperty("Index")]
        public long Index { get; set; }

        [JsonProperty("IsExternal")]
        public bool IsExternal { get; set; }

        [JsonProperty("IsTextSubtitleStream")]
        public bool IsTextSubtitleStream { get; set; }

        [JsonProperty("SupportsExternalStream")]
        public bool SupportsExternalStream { get; set; }

        [JsonProperty("PixelFormat", NullValueHandling = NullValueHandling.Ignore)]
        public string PixelFormat { get; set; }

        [JsonProperty("Level")]
        public long Level { get; set; }

        [JsonProperty("Language", NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }

        [JsonProperty("ChannelLayout", NullValueHandling = NullValueHandling.Ignore)]
        public string ChannelLayout { get; set; }

        [JsonProperty("Channels", NullValueHandling = NullValueHandling.Ignore)]
        public long? Channels { get; set; }

        [JsonProperty("SampleRate", NullValueHandling = NullValueHandling.Ignore)]
        public long? SampleRate { get; set; }

        [JsonProperty("localizedUndefined", NullValueHandling = NullValueHandling.Ignore)]
        public string LocalizedUndefined { get; set; }

        [JsonProperty("localizedDefault", NullValueHandling = NullValueHandling.Ignore)]
        public string LocalizedDefault { get; set; }

        [JsonProperty("localizedForced", NullValueHandling = NullValueHandling.Ignore)]
        public string LocalizedForced { get; set; }
    }

    public partial class ProviderIds
    {
        [JsonProperty("Tvdb")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Tvdb { get; set; }
    }

    public partial class NowPlayingQueue
    {
        [JsonProperty("Id")]
        public string Id { get; set; }

        [JsonProperty("PlaylistItemId")]
        public string PlaylistItemId { get; set; }
    }

    public partial class PlayState
    {
        [JsonProperty("PositionTicks", NullValueHandling = NullValueHandling.Ignore)]
        public long? PositionTicks { get; set; }

        [JsonProperty("CanSeek")]
        public bool CanSeek { get; set; }

        [JsonProperty("IsPaused")]
        public bool IsPaused { get; set; }

        [JsonProperty("IsMuted")]
        public bool IsMuted { get; set; }

        [JsonProperty("MediaSourceId", NullValueHandling = NullValueHandling.Ignore)]
        public string MediaSourceId { get; set; }

        [JsonProperty("PlayMethod", NullValueHandling = NullValueHandling.Ignore)]
        public string PlayMethod { get; set; }

        [JsonProperty("RepeatMode")]
        public string RepeatMode { get; set; }

        [JsonProperty("VolumeLevel", NullValueHandling = NullValueHandling.Ignore)]
        public long? VolumeLevel { get; set; }

        [JsonProperty("AudioStreamIndex", NullValueHandling = NullValueHandling.Ignore)]
        public long? AudioStreamIndex { get; set; }

        [JsonProperty("SubtitleStreamIndex", NullValueHandling = NullValueHandling.Ignore)]
        public long? SubtitleStreamIndex { get; set; }
    }

    public enum ConditionEnum { Equals, EqualsAny, LessThanEqual, NotEquals, GreaterThanEqual };

    public enum MediaTypeElement { Audio, Video };

    public enum Context { Static, Streaming };

    public enum Protocol { Hls, Http };

    public enum TranscodeSeekInfo { Auto };

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                ConditionEnumConverter.Singleton,
                MediaTypeElementConverter.Singleton,
                ContextConverter.Singleton,
                ProtocolConverter.Singleton,
                TranscodeSeekInfoConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class ConditionEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ConditionEnum) || t == typeof(ConditionEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Equals":
                    return ConditionEnum.Equals;
                case "EqualsAny":
                    return ConditionEnum.EqualsAny;
                case "LessThanEqual":
                    return ConditionEnum.LessThanEqual;
                case "NotEquals":
                    return ConditionEnum.NotEquals;
            }
            throw new Exception("Cannot unmarshal type ConditionEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ConditionEnum)untypedValue;
            switch (value)
            {
                case ConditionEnum.Equals:
                    serializer.Serialize(writer, "Equals");
                    return;
                case ConditionEnum.EqualsAny:
                    serializer.Serialize(writer, "EqualsAny");
                    return;
                case ConditionEnum.LessThanEqual:
                    serializer.Serialize(writer, "LessThanEqual");
                    return;
                case ConditionEnum.NotEquals:
                    serializer.Serialize(writer, "NotEquals");
                    return;
            }
            throw new Exception("Cannot marshal type ConditionEnum");
        }

        public static readonly ConditionEnumConverter Singleton = new ConditionEnumConverter();
    }

    internal class MediaTypeElementConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(MediaTypeElement) || t == typeof(MediaTypeElement?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Audio":
                    return MediaTypeElement.Audio;
                case "Video":
                    return MediaTypeElement.Video;
            }
            throw new Exception("Cannot unmarshal type MediaTypeElement");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (MediaTypeElement)untypedValue;
            switch (value)
            {
                case MediaTypeElement.Audio:
                    serializer.Serialize(writer, "Audio");
                    return;
                case MediaTypeElement.Video:
                    serializer.Serialize(writer, "Video");
                    return;
            }
            throw new Exception("Cannot marshal type MediaTypeElement");
        }

        public static readonly MediaTypeElementConverter Singleton = new MediaTypeElementConverter();
    }

    internal class ContextConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Context) || t == typeof(Context?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Static":
                    return Context.Static;
                case "Streaming":
                    return Context.Streaming;
            }
            throw new Exception("Cannot unmarshal type Context");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Context)untypedValue;
            switch (value)
            {
                case Context.Static:
                    serializer.Serialize(writer, "Static");
                    return;
                case Context.Streaming:
                    serializer.Serialize(writer, "Streaming");
                    return;
            }
            throw new Exception("Cannot marshal type Context");
        }

        public static readonly ContextConverter Singleton = new ContextConverter();
    }

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }

    internal class ProtocolConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Protocol) || t == typeof(Protocol?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "hls":
                    return Protocol.Hls;
                case "http":
                    return Protocol.Http;
            }
            throw new Exception("Cannot unmarshal type Protocol");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Protocol)untypedValue;
            switch (value)
            {
                case Protocol.Hls:
                    serializer.Serialize(writer, "hls");
                    return;
                case Protocol.Http:
                    serializer.Serialize(writer, "http");
                    return;
            }
            throw new Exception("Cannot marshal type Protocol");
        }

        public static readonly ProtocolConverter Singleton = new ProtocolConverter();
    }

    internal class TranscodeSeekInfoConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TranscodeSeekInfo) || t == typeof(TranscodeSeekInfo?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "Auto")
            {
                return TranscodeSeekInfo.Auto;
            }
            throw new Exception("Cannot unmarshal type TranscodeSeekInfo");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TranscodeSeekInfo)untypedValue;
            if (value == TranscodeSeekInfo.Auto)
            {
                serializer.Serialize(writer, "Auto");
                return;
            }
            throw new Exception("Cannot marshal type TranscodeSeekInfo");
        }

        public static readonly TranscodeSeekInfoConverter Singleton = new TranscodeSeekInfoConverter();
    }
}
