using System.Text.Json.Serialization;
using AsyncAPIApplication.Data;
using AsyncAPIApplication.Dtos;
using AsyncAPIApplication.Models;
using AsyncAPIApplication.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateSlimBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlite("Data Source=SqliteDbStore.db");
});

builder.Services.ConfigureHttpJsonOptions(options =>
{
    options.SerializerOptions.TypeInfoResolverChain.Insert(0, AppJsonSerializerContext.Default);
});

var app = builder.Build();

app.UseHttpsRedirection();

//Starting endpoint
app.MapPost("api/v1/supplies", async (ApplicationDbContext dbContext, ListOfRequests listOfRequests) =>
{
    if (listOfRequests == null)
    {
        return Results.BadRequest();
    }

    listOfRequests.StatusOfRequest = "ACCEPTED";
    listOfRequests.EstimatedTimeToCompleteTheTask = "2024-08-26:17:00:00";

    await dbContext.Requests.AddAsync(listOfRequests);
    await dbContext.SaveChangesAsync();

    return Results.Accepted($"api/v1/supplies/status/{listOfRequests.RequestId}", listOfRequests);
});

//Status endpoint
app.MapGet("api/v1/supplies/status/{requestId}", async (ApplicationDbContext dbContext, string requestId) =>
{
    var listedRequest = await dbContext.Requests.FirstOrDefaultAsync(request => request.RequestId == requestId);

    if (listedRequest == null)
    {
        return Results.NotFound();
    }

    var listingStatus = new ListingStatus
    {
        StatusOfRequest = listedRequest.StatusOfRequest,
        ResourceURL = string.Empty
    };

    if (listedRequest.StatusOfRequest!.ToUpper() == "COMPLETE")
    {
        listingStatus.ResourceURL = $"api/v1/supplies/{Guid.NewGuid().ToString()}";

        // return Results.Ok(listingStatus);
        return Results.Redirect("http://localhost:5185/" + listingStatus.ResourceURL);
    }

    listingStatus.EstimatedTimeToCompleteTheTask = "2024-08-26:18:00:00";

    return Results.Ok(listingStatus);
});

app.MapGet("api/v1/supplies/{requestId}", (string requestId) =>
{
    return Results.Ok($"There is a result we want to receive with request id equals to {requestId}");
});

app.Run();
