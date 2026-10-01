public class Movie {
	private string title;
	private int year;
	private string directorFirstName;
	private string directorLastName;
	private double rating;

	public Movie(string title, int year, string directorFirstName, string directorLastName, double rating) {
		Title = title;
		Year = year;
		DirectorFirstName = directorFirstName;
		DirectorLastName = directorLastName;
		Rating = rating;
	}

	public override string ToString() {
		return $"{Title} by {DirectorFirstName} {DirectorLastName} ({Year}) rated {Rating:N2} / 5 stars";
	}

	public string Title {
		get => title;

		set {
			if (string.IsNullOrWhiteSpace(value)) {
				throw new ArgumentException("Title cannot be empty", nameof(Title));
			}

			title = value;
		}
	}

	public string DirectorFirstName {
		get => directorFirstName;
		set {
			if (string.IsNullOrWhiteSpace(value)) {
				throw new ArgumentException("Director's first name cannot be empty", nameof(DirectorFirstName));
			}

			directorFirstName = value;
		}
	}

	public string DirectorLastName {
		get => directorLastName;
		set {
			if (string.IsNullOrWhiteSpace(value)) {
				throw new ArgumentException("Director's last name cannot be empty", nameof(DirectorLastName));
			}

			directorLastName = value;
		}
	}

	public double Rating {
		get => rating;

		set {
			if (value < 0 || value > 5) {
				throw new ArgumentOutOfRangeException(nameof(Rating));
			}

			rating = value;
		}
	}

	public int Year {
		get => year;

		set {
			if (value < 1900 || value > DateTime.Now.Year + 1) {
				throw new ArgumentOutOfRangeException(nameof(Year));
			}

			year = value;
		}
	}
}
