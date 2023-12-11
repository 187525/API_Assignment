using RestSharp;
using Newtonsoft;
using Newtonsoft.Json.Linq;

string baseUrl = "https://jsonplaceholder.typicode.com/";
var client = new RestClient(baseUrl);

GetAllUsers(client);
CreateUser(client);
UpdateUser(client);
DeleteUser(client);
GetSingleUser(client);


//GET All Users
static void GetAllUsers(RestClient client)
{
    var getUserRequest = new RestRequest("posts", Method.Get);
    

    var getUserResponse = client.Execute(getUserRequest);
    Console.WriteLine("GET Response: \n" + getUserResponse.Content);
}

//POST
static void CreateUser(RestClient client)
{
    var createUserRequest = new RestRequest("posts", Method.Post);
    createUserRequest.AddHeader("Content-Type", "application/json");
    createUserRequest.AddJsonBody(new { title = "foo", body = "bar",userId="1" });

    var createUserResponse = client.Execute(createUserRequest);
    Console.WriteLine("POST Response: \n" + createUserResponse.Content);
}

//PUT
static void UpdateUser(RestClient client)
{
    var updateUserRequest = new RestRequest("posts/1", Method.Put);
    updateUserRequest.AddHeader("Content-Type", "application/json");
    updateUserRequest.AddJsonBody(new { title = "foo", body = "bar", userId = "1" });

    var updateUserResponse = client.Execute(updateUserRequest);
    Console.WriteLine("PUT Response: \n" + updateUserResponse.Content);
}

//DELETE
static void DeleteUser(RestClient client)
{
    var deleteUserRequest = new RestRequest("posts/1", Method.Delete);
    var deleteUserResponse = client.Execute(deleteUserRequest);
    Console.WriteLine("DELETE Response: \n" + deleteUserResponse.Content);
}

//GET Single User
static void GetSingleUser(RestClient client)
{
    var getUserRequest = new RestRequest("posts/1", Method.Get);

    var getUserResponse = client.Execute(getUserRequest);
    if (getUserResponse.StatusCode == System.Net.HttpStatusCode.OK)
    {
        //Parse Json response content
        JObject? userJson = JObject.Parse(getUserResponse.Content);

        string? userTitle = userJson["title"].ToString();
        string? userBody = userJson["body"].ToString();
        string? userId = userJson["userId"].ToString();


        Console.WriteLine($"UserTitle: {userTitle} \n UserBody: {userBody} \n  UserId: {userId}");
    }
    else
    {
        Console.WriteLine($"Error: {getUserResponse.ErrorMessage}");
    }
}