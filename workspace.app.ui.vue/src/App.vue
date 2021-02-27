<template>
  <div id="app">
    <ul>
      <li v-for="item in items" :key="item.id">{{item.firstname}} - {{item.lastname}}</li>
    </ul>
  </div>
</template>

<script>
import axios from "axios";
export default {
  name: "App",
  data() {
    return {
      items: [],
    };
  },
  mounted() {
    axios.get("http://localhost:5000/users/get").then((res) => {
      this.items = res.data;
    });
  },
};
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
