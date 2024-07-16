using System;
using Rx.Http;
using Rx.Http.Extensions;
using Swagger.Petstore.Models;

namespace Swagger.Petstore
{
    class PetstoreConsumer : RxHttpClient
    {
        public PetstoreConsumer(HttpClient httpClient) : base(httpClient, null)
        {
            httpClient.BaseAddress = new Uri("https://petstore.swagger.io/v2");
        }

        public IObservable<ApiResponse> UploadFile(MultipartFormDataContent body, int petId)
        {
            return Post<ApiResponse>($"/pet/{petId}/uploadImage", body);
        }
        public IObservable<RxHttpResponse> UpdatePet(Pet body)
        {
            return Put($"/pet", body);
        }
        public IObservable<RxHttpResponse> AddPet(Pet body)
        {
            return Post($"/pet", body);
        }
        public IObservable<List<Pet>> FindPetsByStatus(List<string> status)
        {
            return Get<List<Pet>>($"/pet/findByStatus", null, options => {
                options.AddQueryString("status", status);
            });
        }
        public IObservable<List<Pet>> FindPetsByTags(List<string> tags)
        {
            return Get<List<Pet>>($"/pet/findByTags", null, options => {
                options.AddQueryString("tags", tags);
            });
        }
        public IObservable<Pet> GetPetById(int petId)
        {
            return Get<Pet>($"/pet/{petId}");
        }
        public IObservable<RxHttpResponse> UpdatePetWithForm(string name, string status, int petId)
        {
            return Post($"/pet/{petId}", new FormUrlEncodedContent(new Dictionary<string, string>
            {
                { "name", name },
                { "status", status }
            }));
        }
        public IObservable<RxHttpResponse> DeletePet(string apiKey, int petId)
        {
            return Delete($"/pet/{petId}", null, options => {
                options.AddHeader("api_key", apiKey);
            });
        }
        public IObservable<object> GetInventory()
        {
            return Get<object>($"/store/inventory");
        }
        public IObservable<Order> PlaceOrder(Order body)
        {
            return Post<Order>($"/store/order", body);
        }
        public IObservable<Order> GetOrderById(int orderId)
        {
            return Get<Order>($"/store/order/{orderId}");
        }
        public IObservable<RxHttpResponse> DeleteOrder(int orderId)
        {
            return Delete($"/store/order/{orderId}");
        }
        public IObservable<RxHttpResponse> CreateUsersWithListInput(List<User> body)
        {
            return Post($"/user/createWithList", body);
        }
        public IObservable<User> GetUserByName(string username)
        {
            return Get<User>($"/user/{username}");
        }
        public IObservable<RxHttpResponse> UpdateUser(User body, string username)
        {
            return Put($"/user/{username}", body);
        }
        public IObservable<RxHttpResponse> DeleteUser(string username)
        {
            return Delete($"/user/{username}");
        }
        public IObservable<string> LoginUser(string username, string password)
        {
            return Get<string>($"/user/login", null, options => {
                options.AddQueryString("username", username);
                options.AddQueryString("password", password);
            });
        }
        public IObservable<RxHttpResponse> LogoutUser()
        {
            return Get($"/user/logout");
        }
        public IObservable<RxHttpResponse> CreateUsersWithArrayInput(List<User> body)
        {
            return Post($"/user/createWithArray", body);
        }
        public IObservable<RxHttpResponse> CreateUser(User body)
        {
            return Post($"/user", body);
        }
    }
}
