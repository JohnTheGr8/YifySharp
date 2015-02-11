## YifySharp [![AppVeyor](https://img.shields.io/appveyor/ci/JohnTheGr8/yifysharp.svg?style=flat-square)](https://ci.appveyor.com/project/JohnTheGr8/yifysharp) [![NuGet](https://img.shields.io/nuget/v/YifySharp.svg?style=flat-square)](https://www.nuget.org/packages/YifySharp/)

#### About

A .NET implementation of the [YIFY API](https://yts.re/api/).

#### Install

```powershell
	PM> Install-Package YifySharp
```

#### Supported API calls

- `GetMovieList` : list, search, and filter available movies
- `GetMovieDetails` : get more information (like trailer link, cast)
- `GetMovieSuggestions` : movie suggestions based on another movie
- `GetMovieComments` : get comments of a movie
- `GetReviews` : get reviews of a movie
- `GetParentalGuides` : get parental guide ratings of a movie
- `GetUpcomingList` : get list that will soon be uploaded
- `GetUserDetails` : get details of a registered user
