using Newtonsoft.Json;

using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

using static AntiAfkV2.GitHubUpdate.Schemes;

// Taken from an unreleased version of ScriptsLib.

namespace AntiAfkV2
{
	public static class GitHubUpdate
	{
		public static void CheckNewVersion()
		{
			try
			{
				string[] versionSplit = Application.ProductVersion.Split('.');
				if (GetLatestRelease().TagName != $"v{versionSplit[0]}.{versionSplit[1]}")
				{
					MessageBox.Show("A new version for AntiAFK is available.", "AntiAFK", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch { }
		}

		private static Release GetLatestRelease()
		{
			HttpWebRequest request = GetHttpWebRequest($"https://api.github.com/repos/Milkenm/AntiAFK/releases/latest");
			request.UserAgent = "request";
			return GET<Release>(request);
		}

		private static HttpWebRequest GetHttpWebRequest(string url)
		{
			return (HttpWebRequest)WebRequest.Create(url);
		}

		private static T GET<T>(HttpWebRequest request)
		{
			string response = GET(request);
			return JsonConvert.DeserializeObject<T>(response);
		}

		private static string GET(HttpWebRequest request)
		{
			/* HttpStatusCode a = ((HttpWebResponse)request.GetResponse()).StatusCode; */
			return ParseResponse(request.GetResponse());
		}

		private static string ParseResponse(WebResponse response)
		{
			using (Stream stream = response.GetResponseStream())
			{
				StreamReader reader = new StreamReader(stream, Encoding.UTF8);
				return reader.ReadToEnd();
			}
		}

		public class Schemes
		{
			public class Release
			{
				[JsonProperty("url")] public string Url { get; set; }
				[JsonProperty("assets_url")] public string AssetsUrl { get; set; }
				[JsonProperty("upload_url")] public string UploadUrl { get; set; }
				[JsonProperty("html_url")] public string HtmlUrl { get; set; }
				[JsonProperty("id")] public int Id { get; set; }
				[JsonProperty("author")] public User Author { get; set; }
				[JsonProperty("node_id")] public string NodeId { get; set; }
				[JsonProperty("tag_name")] public string TagName { get; set; }
				[JsonProperty("target_commitish")] public string TargetCommitish { get; set; }
				[JsonProperty("name")] public string Name { get; set; }
				[JsonProperty("draft")] public bool IsDraft { get; set; }
				[JsonProperty("prerelease")] public bool IsPrerelease { get; set; }
				[JsonProperty("created_at")] public string CreatedAt { get; set; }
				[JsonProperty("published_at")] public string PublishedAt { get; set; }
				[JsonProperty("assets")] public Asset[] Assets { get; set; }
				[JsonProperty("tarball_url")] public string TarballUrl { get; set; }
				[JsonProperty("zipball_url")] public string ZipballUrl { get; set; }
				[JsonProperty("body")] public string Body { get; set; }
			}

			public class Asset
			{
				[JsonProperty("url")] public string Url { get; set; }
				[JsonProperty("id")] public int Id { get; set; }
				[JsonProperty("node_id")] public string NodeId { get; set; }
				[JsonProperty("name")] public string Name { get; set; }
				[JsonProperty("label")] public string Label { get; set; }
				[JsonProperty("uploader")] public User Uploader { get; set; }
				[JsonProperty("content_type")] public string ContentType { get; set; }
				[JsonProperty("state")] public string State { get; set; }
				[JsonProperty("size")] public int Size { get; set; }
				[JsonProperty("download_count")] public int DownloadCount { get; set; }
				[JsonProperty("created_at")] public string CreatedAt { get; set; }
				[JsonProperty("updated_at")] public string UpdatedAt { get; set; }
				[JsonProperty("browser_download_url")] public string BrowserDownloadUrl { get; set; }
			}

			public class User
			{
				[JsonProperty("login")] public string Login { get; set; }
				[JsonProperty("id")] public int Id { get; set; }
				[JsonProperty("node_id")] public string NodeId { get; set; }
				[JsonProperty("avatar_url")] public string AvatarUrl { get; set; }
				[JsonProperty("gravatar_id")] public int? GravatarId { get; set; }
				[JsonProperty("url")] public string Url { get; set; }
				[JsonProperty("html_url")] public string HtmlUrl { get; set; }
				[JsonProperty("followers_url")] public string FollowersUrl { get; set; }
				[JsonProperty("following_url")] public string FollowingUrl { get; set; }
				[JsonProperty("gists_url")] public string GistsUrl { get; set; }
				[JsonProperty("starred_url")] public string StarredUrl { get; set; }
				[JsonProperty("subscriptions_url")] public string SubscriptionsUrl { get; set; }
				[JsonProperty("organizations_url")] public string OrganizationsUrl { get; set; }
				[JsonProperty("repos_url")] public string ReposUrl { get; set; }
				[JsonProperty("events_url")] public string EventsUrl { get; set; }
				[JsonProperty("received_events_url")] public string ReceivedEventsUrl { get; set; }
				[JsonProperty("type")] public string Type { get; set; }
				[JsonProperty("IsSiteAdmin")] public bool SiteAdmin { get; set; }
			}
		}
	}
}
