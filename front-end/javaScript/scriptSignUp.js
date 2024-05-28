

function SignUpUser() {
  const email = document.getElementById("email").value;
  const name = document.getElementById("name").value;
  const password = document.getElementById("password").value;
  const user = { name, email, password };

  axios
    .post(
      "/api/account/register",
      {
        params: {
          registerDto: user,
        },
      }
    )
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
