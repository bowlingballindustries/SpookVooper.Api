﻿using Newtonsoft.Json;

namespace SpookVooper.Api.Entities
{
    /// <summary>
    /// This class exists to strip out sensitive data and provide only what the API
    /// should pass to endpoints. It does not automatically update and serves as a "snapshot" of the user at that moment.
    /// </summary>
    public class UserSnapshot : EntitySnapshot
    {
        [JsonProperty]
        public string UserName { get; set; }

        // Other accounts
        [JsonProperty]
        public string twitch_id { get; set; }

        [JsonProperty]
        public ulong? discord_id { get; set; }

        // Forum stuff
        [JsonProperty]
        public int post_likes { get; set; }

        [JsonProperty]
        public int comment_likes { get; set; }

        // NationStates nation
        [JsonProperty]
        public string nationstate { get; set; }

        // Description
        [JsonProperty]
        public string description { get; set; }

        [JsonProperty]
        public int api_use_count { get; set; }

        [JsonProperty]
        public string minecraft_id { get; set; }

        // Twitch stuff
        [JsonProperty]
        public int twitch_last_message_minute { get; set; }

        [JsonProperty]
        public int twitch_message_xp { get; set; }

        [JsonProperty]
        public int twitch_messages { get; set; }

        // Discord stuff
        [JsonProperty]
        public int discord_commends { get; set; }

        [JsonProperty]
        public int discord_commends_sent { get; set; }

        [JsonProperty]
        public int discord_last_commend_hour { get; set; }

        [JsonProperty]
        public ulong discord_last_commend_message { get; set; }

        [JsonProperty]
        public int discord_message_xp { get; set; }

        [JsonProperty]
        public int discord_message_count { get; set; }

        [JsonProperty]
        public int discord_last_message_minute { get; set; }

        [JsonProperty]
        public int discord_warning_count { get; set; }

        [JsonProperty]
        public int discord_ban_count { get; set; }

        [JsonProperty]
        public int discord_kick_count { get; set; }

        [JsonProperty]
        public int discord_game_xp { get; set; }

        // Government Stuff
        [JsonProperty]
        public string district { get; set; }
    }
}
