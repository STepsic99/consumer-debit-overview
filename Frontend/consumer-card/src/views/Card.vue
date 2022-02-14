<template>
  <div style="max-width:50%; text-align: center;margin: auto; margin-top:2% ">
    <h1 style="margin-bottom:5%">{{this.username}}</h1>
  <table class="table">
  <thead>
    <tr>
      <th scope="col">Datum</th>
      <th scope="col">Dokument</th>
      <th scope="col">Duguje</th>
      <th scope="col">Potrazuje</th>
      <th scope="col">Saldo</th>
    </tr>
  </thead>
   <tbody>
   <tr v-for="t in traffics" :key="t.id">
      <td>{{t.date}}</td>
      <td>{{t.document}}</td>
      <td>{{t.owes}}</td>
      <td>{{t.claims}}</td>
      <td>{{t.saldo}}</td>
     </tr>
  </tbody>
  </table><br>
  <button type="submit" class="btn btn-primary" v-on:click="signOut()">Odjavi se</button>

  </div>
</template>

<script>
// @ is an alias to /src

import axios from "axios";
import moment from 'moment';
export default {
  name: 'Card',
  components: {
  
  },
  data: function(){
    return {
      username: '',
      traffics: []
    }
  },
  methods:{
    signOut:function(){
      window.sessionStorage.clear();
      this.$router.push('/');
    }
  },
  mounted: function(){
      axios.defaults.headers.common["Authorization"] =
                "Bearer " + window.sessionStorage.getItem("jwt");  
     axios
          .get('http://localhost:59666/api/users/traffic')
          .then(response => {this.traffics=response.data;
            for(var i=0; i<this.traffics.length; i++){
              this.traffics[i].date = moment(String(this.traffics[i].date)).format('DD/MM/YYYY')
            }
            axios
          .get('http://localhost:59666/api/users')
          .then(response=>this.username=response.data)
          }).catch(err => {
              alert('DOSLO JE DO GRESKE')
          });    
  }
}
</script>
