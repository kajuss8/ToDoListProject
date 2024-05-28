
function loginUser() {
  const email = document.getElementById("email").value;
  const password = document.getElementById("password").value;
  const user = { email, password };

  axios
    .post("/api/account/login", {
      params: {
        loginDto: user,
      },
    })
    .then(function (response) {
      console.log(response);
      console.log("hello world");
    })
    .catch(function (error) {
      console.log(error);
    })
    .finally(function () {
      // always executed
    });
    
}
