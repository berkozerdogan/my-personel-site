<template>
  <div class="col">
    <div class="user"></div>
    <form>
      <h1>Log In</h1>
      <div class="input">
        <input type="text" required v-model="username" />
        <label>Username</label>
        <div class="forgot"><a href="#">Forgot Password?</a></div>
      </div>
      <div class="input box">
        <input type="text" required v-model="password" />
        <label>Password</label>
        <div class="forgot"><a href="#">Forgot Password?</a></div>
      </div>
      <input type="submit" @click="login" />
    </form>
    <div class="div">
      <div class="line"></div>
      <div class="signup">
        Don't Have an Account?
        <a href="#">Sign Up</a>
      </div>
    </div>

    <div
      class="modal fade"
      id="userPage"
      tabindex="-1"
      aria-labelledby="exampleModalLabel"
      aria-hidden="true"
    >
      <div class="modal-dialog modal-xl">
        <div class="modal-content">
          <div class="modal-header">
            <h5 class="modal-title" id="exampleModalLabel">
              Animasyon Efekti Örneği
            </h5>
            <button
              type="button"
              class="btn-close"
              data-bs-dismiss="modal"
              aria-label="Close"
            ></button>
          </div>
          <div class="modal-body"><ProjectUser /></div>
          <div class="modal-footer">
            <button
              type="button"
              class="btn btn-secondary"
              data-bs-dismiss="modal"
            >
              Close
            </button>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  data() {
    return {
      isAuthorized: false,
      username: null,
      password: null,
      users: [{ userName: "admin", password: "admin" }],
    };
  },
  methods: {
    login() {
      let userInfo = {
        username: this.username,
        password: this.password,
      };
      this.users.push(userInfo);
      this.isAuthorized = true;
    },
  },
};
</script>

<style scoped>
* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
  color: white;
  font-family: "Poppins", sans-serif;
}

.flex {
  display: flex;
  align-items: center;
  justify-content: center;
}
.col {
  margin-top: 200px;
  position: relative;
  width: 310px;
  height: 370px;
  border-radius: 5px;
  background-color: #131313;
  padding: 65px 40px 20px 40px;
  box-shadow: 10px 10px 20px rgba(0, 0, 0, 0.505),
    -10px -10px 20px rgba(0, 0, 0, 0.361);
}
.user {
  background-image: url(https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSOIIeu7EUcCJWIIdXcQbf24rjpf-uSzIVwew&usqp=CAU);
  background-size: cover;
  width: 90px;
  height: 90px;
  background-color: red;
  border-radius: 50%;
  position: absolute;
  left: 110px;
  top: -40px;
}
form h1 {
  text-align: center;
  font-family: "Roboto", sans-serif;
  font-size: 30px;
}
.input {
  margin: 20px 0;
  position: relative;
}
.input input {
  width: 100%;
  height: 40px;
  background: transparent;
  outline: none;
  border: none;
  border-bottom: 0.4px solid rgba(255, 0, 0, 0.46);
  font-size: 17px;
  padding-top: 20px;
}
.input label {
  position: absolute;
  left: 0;
  bottom: 5px;
  pointer-events: none;
  transition: 0.6s;
  font-size: 14px;
}
form input:focus + label,
input:valid ~ label {
  bottom: 24px;
  left: 2px;
  color: red;
  font-size: 13px;
}
form input[type="submit"] {
  padding: 4px 20px;
  border: none;
  outline: none;
  cursor: pointer;
  margin-top: 10px;
  padding: 3px 20px;
  font-size: 15px;
  background-color: red;
}
.box {
  position: relative;
}
.forgot {
  position: absolute;
  font-size: 10px;
  padding: 5px 0;
  right: 0;
}
.signup {
  font-size: 12px;
  padding: 2px;
  text-align: center;
}
a {
  color: red;
  text-decoration: none;
}
a:hover {
  text-decoration: none;
}
.line {
  background-color: white;
  width: 100%;
  height: 0.2px;
  opacity: 0.2;
  margin-top: 30px;
}
.div {
  position: absolute;
  left: 0;
  width: 100%;
}
</style>
