/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.16.3
 * Contact: vrchatapi.lpv0t@aries.fyi
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = VRChat.API.Client.OpenAPIDateConverter;

namespace VRChat.API.Model
{
    /// <summary>
    /// LimitedUser
    /// </summary>
    [DataContract(Name = "LimitedUser")]
    public partial class LimitedUser : IEquatable<LimitedUser>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets DeveloperType
        /// </summary>
        [DataMember(Name = "developerType", IsRequired = true, EmitDefaultValue = true)]
        public DeveloperType DeveloperType { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public UserStatus Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LimitedUser" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LimitedUser() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LimitedUser" /> class.
        /// </summary>
        /// <param name="bio">bio.</param>
        /// <param name="currentAvatarImageUrl">When profilePicOverride is not empty, use it instead..</param>
        /// <param name="currentAvatarThumbnailImageUrl">When profilePicOverride is not empty, use it instead..</param>
        /// <param name="developerType">developerType (required).</param>
        /// <param name="displayName">displayName (required).</param>
        /// <param name="fallbackAvatar">fallbackAvatar.</param>
        /// <param name="id">A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed. (required).</param>
        /// <param name="isFriend">isFriend (required).</param>
        /// <param name="lastPlatform">This can be &#x60;standalonewindows&#x60; or &#x60;android&#x60;, but can also pretty much be any random Unity verison such as &#x60;2019.2.4-801-Release&#x60; or &#x60;2019.2.2-772-Release&#x60; or even &#x60;unknownplatform&#x60;. (required).</param>
        /// <param name="profilePicOverride">profilePicOverride.</param>
        /// <param name="status">status (required).</param>
        /// <param name="statusDescription">statusDescription (required).</param>
        /// <param name="tags">&lt;- Always empty. (required).</param>
        /// <param name="userIcon">userIcon.</param>
        /// <param name="username">-| **DEPRECATED:** VRChat API no longer return usernames of other users. [See issue by Tupper for more information](https://github.com/pypy-vrc/VRCX/issues/429)..</param>
        /// <param name="location">location.</param>
        /// <param name="friendKey">friendKey.</param>
        public LimitedUser(string bio = default(string), string currentAvatarImageUrl = default(string), string currentAvatarThumbnailImageUrl = default(string), DeveloperType developerType = default(DeveloperType), string displayName = default(string), string fallbackAvatar = default(string), string id = default(string), bool isFriend = default(bool), string lastPlatform = default(string), string profilePicOverride = default(string), UserStatus status = default(UserStatus), string statusDescription = default(string), List<string> tags = default(List<string>), string userIcon = default(string), string username = default(string), string location = default(string), string friendKey = default(string))
        {
            this.DeveloperType = developerType;
            // to ensure "displayName" is required (not null)
            if (displayName == null)
            {
                throw new ArgumentNullException("displayName is a required property for LimitedUser and cannot be null");
            }
            this.DisplayName = displayName;
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for LimitedUser and cannot be null");
            }
            this.Id = id;
            this.IsFriend = isFriend;
            // to ensure "lastPlatform" is required (not null)
            if (lastPlatform == null)
            {
                throw new ArgumentNullException("lastPlatform is a required property for LimitedUser and cannot be null");
            }
            this.LastPlatform = lastPlatform;
            this.Status = status;
            // to ensure "statusDescription" is required (not null)
            if (statusDescription == null)
            {
                throw new ArgumentNullException("statusDescription is a required property for LimitedUser and cannot be null");
            }
            this.StatusDescription = statusDescription;
            // to ensure "tags" is required (not null)
            if (tags == null)
            {
                throw new ArgumentNullException("tags is a required property for LimitedUser and cannot be null");
            }
            this.Tags = tags;
            this.Bio = bio;
            this.CurrentAvatarImageUrl = currentAvatarImageUrl;
            this.CurrentAvatarThumbnailImageUrl = currentAvatarThumbnailImageUrl;
            this.FallbackAvatar = fallbackAvatar;
            this.ProfilePicOverride = profilePicOverride;
            this.UserIcon = userIcon;
            this.Username = username;
            this.Location = location;
            this.FriendKey = friendKey;
        }

        /// <summary>
        /// Gets or Sets Bio
        /// </summary>
        [DataMember(Name = "bio", EmitDefaultValue = false)]
        public string Bio { get; set; }

        /// <summary>
        /// When profilePicOverride is not empty, use it instead.
        /// </summary>
        /// <value>When profilePicOverride is not empty, use it instead.</value>
        [DataMember(Name = "currentAvatarImageUrl", EmitDefaultValue = false)]
        public string CurrentAvatarImageUrl { get; set; }

        /// <summary>
        /// When profilePicOverride is not empty, use it instead.
        /// </summary>
        /// <value>When profilePicOverride is not empty, use it instead.</value>
        [DataMember(Name = "currentAvatarThumbnailImageUrl", EmitDefaultValue = false)]
        public string CurrentAvatarThumbnailImageUrl { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "displayName", IsRequired = true, EmitDefaultValue = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets FallbackAvatar
        /// </summary>
        [DataMember(Name = "fallbackAvatar", EmitDefaultValue = false)]
        public string FallbackAvatar { get; set; }

        /// <summary>
        /// A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.
        /// </summary>
        /// <value>A users unique ID, usually in the form of &#x60;usr_c1644b5b-3ca4-45b4-97c6-a2a0de70d469&#x60;. Legacy players can have old IDs in the form of &#x60;8JoV9XEdpo&#x60;. The ID can never be changed.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets IsFriend
        /// </summary>
        [DataMember(Name = "isFriend", IsRequired = true, EmitDefaultValue = true)]
        public bool IsFriend { get; set; }

        /// <summary>
        /// This can be &#x60;standalonewindows&#x60; or &#x60;android&#x60;, but can also pretty much be any random Unity verison such as &#x60;2019.2.4-801-Release&#x60; or &#x60;2019.2.2-772-Release&#x60; or even &#x60;unknownplatform&#x60;.
        /// </summary>
        /// <value>This can be &#x60;standalonewindows&#x60; or &#x60;android&#x60;, but can also pretty much be any random Unity verison such as &#x60;2019.2.4-801-Release&#x60; or &#x60;2019.2.2-772-Release&#x60; or even &#x60;unknownplatform&#x60;.</value>
        [DataMember(Name = "last_platform", IsRequired = true, EmitDefaultValue = true)]
        public string LastPlatform { get; set; }

        /// <summary>
        /// Gets or Sets ProfilePicOverride
        /// </summary>
        [DataMember(Name = "profilePicOverride", EmitDefaultValue = false)]
        public string ProfilePicOverride { get; set; }

        /// <summary>
        /// Gets or Sets StatusDescription
        /// </summary>
        [DataMember(Name = "statusDescription", IsRequired = true, EmitDefaultValue = true)]
        public string StatusDescription { get; set; }

        /// <summary>
        /// &lt;- Always empty.
        /// </summary>
        /// <value>&lt;- Always empty.</value>
        [DataMember(Name = "tags", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Gets or Sets UserIcon
        /// </summary>
        [DataMember(Name = "userIcon", EmitDefaultValue = false)]
        public string UserIcon { get; set; }

        /// <summary>
        /// -| **DEPRECATED:** VRChat API no longer return usernames of other users. [See issue by Tupper for more information](https://github.com/pypy-vrc/VRCX/issues/429).
        /// </summary>
        /// <value>-| **DEPRECATED:** VRChat API no longer return usernames of other users. [See issue by Tupper for more information](https://github.com/pypy-vrc/VRCX/issues/429).</value>
        [DataMember(Name = "username", EmitDefaultValue = false)]
        [Obsolete]
        public string Username { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name = "location", EmitDefaultValue = false)]
        public string Location { get; set; }

        /// <summary>
        /// Gets or Sets FriendKey
        /// </summary>
        [DataMember(Name = "friendKey", EmitDefaultValue = false)]
        public string FriendKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LimitedUser {\n");
            sb.Append("  Bio: ").Append(Bio).Append("\n");
            sb.Append("  CurrentAvatarImageUrl: ").Append(CurrentAvatarImageUrl).Append("\n");
            sb.Append("  CurrentAvatarThumbnailImageUrl: ").Append(CurrentAvatarThumbnailImageUrl).Append("\n");
            sb.Append("  DeveloperType: ").Append(DeveloperType).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  FallbackAvatar: ").Append(FallbackAvatar).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsFriend: ").Append(IsFriend).Append("\n");
            sb.Append("  LastPlatform: ").Append(LastPlatform).Append("\n");
            sb.Append("  ProfilePicOverride: ").Append(ProfilePicOverride).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusDescription: ").Append(StatusDescription).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  UserIcon: ").Append(UserIcon).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  FriendKey: ").Append(FriendKey).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as LimitedUser);
        }

        /// <summary>
        /// Returns true if LimitedUser instances are equal
        /// </summary>
        /// <param name="input">Instance of LimitedUser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LimitedUser input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Bio == input.Bio ||
                    (this.Bio != null &&
                    this.Bio.Equals(input.Bio))
                ) && 
                (
                    this.CurrentAvatarImageUrl == input.CurrentAvatarImageUrl ||
                    (this.CurrentAvatarImageUrl != null &&
                    this.CurrentAvatarImageUrl.Equals(input.CurrentAvatarImageUrl))
                ) && 
                (
                    this.CurrentAvatarThumbnailImageUrl == input.CurrentAvatarThumbnailImageUrl ||
                    (this.CurrentAvatarThumbnailImageUrl != null &&
                    this.CurrentAvatarThumbnailImageUrl.Equals(input.CurrentAvatarThumbnailImageUrl))
                ) && 
                (
                    this.DeveloperType == input.DeveloperType ||
                    this.DeveloperType.Equals(input.DeveloperType)
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.FallbackAvatar == input.FallbackAvatar ||
                    (this.FallbackAvatar != null &&
                    this.FallbackAvatar.Equals(input.FallbackAvatar))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IsFriend == input.IsFriend ||
                    this.IsFriend.Equals(input.IsFriend)
                ) && 
                (
                    this.LastPlatform == input.LastPlatform ||
                    (this.LastPlatform != null &&
                    this.LastPlatform.Equals(input.LastPlatform))
                ) && 
                (
                    this.ProfilePicOverride == input.ProfilePicOverride ||
                    (this.ProfilePicOverride != null &&
                    this.ProfilePicOverride.Equals(input.ProfilePicOverride))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.StatusDescription == input.StatusDescription ||
                    (this.StatusDescription != null &&
                    this.StatusDescription.Equals(input.StatusDescription))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.UserIcon == input.UserIcon ||
                    (this.UserIcon != null &&
                    this.UserIcon.Equals(input.UserIcon))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.FriendKey == input.FriendKey ||
                    (this.FriendKey != null &&
                    this.FriendKey.Equals(input.FriendKey))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Bio != null)
                {
                    hashCode = (hashCode * 59) + this.Bio.GetHashCode();
                }
                if (this.CurrentAvatarImageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.CurrentAvatarImageUrl.GetHashCode();
                }
                if (this.CurrentAvatarThumbnailImageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.CurrentAvatarThumbnailImageUrl.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DeveloperType.GetHashCode();
                if (this.DisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayName.GetHashCode();
                }
                if (this.FallbackAvatar != null)
                {
                    hashCode = (hashCode * 59) + this.FallbackAvatar.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsFriend.GetHashCode();
                if (this.LastPlatform != null)
                {
                    hashCode = (hashCode * 59) + this.LastPlatform.GetHashCode();
                }
                if (this.ProfilePicOverride != null)
                {
                    hashCode = (hashCode * 59) + this.ProfilePicOverride.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.StatusDescription != null)
                {
                    hashCode = (hashCode * 59) + this.StatusDescription.GetHashCode();
                }
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
                if (this.UserIcon != null)
                {
                    hashCode = (hashCode * 59) + this.UserIcon.GetHashCode();
                }
                if (this.Username != null)
                {
                    hashCode = (hashCode * 59) + this.Username.GetHashCode();
                }
                if (this.Location != null)
                {
                    hashCode = (hashCode * 59) + this.Location.GetHashCode();
                }
                if (this.FriendKey != null)
                {
                    hashCode = (hashCode * 59) + this.FriendKey.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
