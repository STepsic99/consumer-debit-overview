<template>
  <div style="max-width:50%; text-align: center;margin: auto; margin-top:10% ">
  
  <div  class="mb-3">
    <label for="exampleInputEmail1" class="form-label">Korisničko ime</label>
    <input v-model="username" type="text" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp">
  </div>
  <div class="mb-3">
    <label for="exampleInputPassword1" class="form-label">Lozinka</label>
    <input type="password" v-model="password" class="form-control" id="exampleInputPassword1">
  </div>
  <button type="submit" class="btn btn-primary" v-on:click="signIn()">Prijavi se</button>

  </div>
</template>

<script>
// @ is an alias to /src

import axios from "axios";
export default {
  name: 'Home',
  components: {
  
  },
  data: function(){
    return {
      username: '',
      password: ''
    }
  },
  methods:{
    signIn:function(){
      axios
        .post("http://localhost:59666/api/users/login", {"username":this.username, "password":this.password})
        .then((response) =>{
          window.sessionStorage.setItem("jwt", response.data.token)
         // window.sessionStorage.setItem("role", response.data.role)
          this.$router.push('/about');
        }).catch(err => {
              alert(err.response.data)
          });
    }
  }
}
</script>
