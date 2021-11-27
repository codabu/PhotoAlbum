using System;


//Photo class to store photo data
public class Photo
{
	public Photo()
	{
	}

	//fields
    private int AlbumId { get; set; }
	private int Id { get; set; }
	private string? Title { get; set; }
	private string? Url { get; set; }
	private string? ThumbnailUrl { get; set; }


	//properties
	public int albumId
    {
		get { return AlbumId; }
		set { AlbumId = value; }
    }

	public int id
    {
		get { return Id; }
		set { Id = value; }
    }

	public string? title
    {
		get { return Title; }
		set { Title = value; }
    }

	public String? url
    {
		get { return Url; }
		set { Url = value; }
    }

	public string? thumbnailUrl
    {
		get { return ThumbnailUrl; }
		set { ThumbnailUrl = value; }
    }
}
