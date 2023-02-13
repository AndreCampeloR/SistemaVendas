<template>
  <div>
 <NavBar/>
 <FooterHome/>
</div>
</template>

<script>
import NavBar from './components/NavBar.vue'
import FooterHome from './components/FooterHome.vue'
export default {
 components: {
   NavBar,
   FooterHome
 }
}
</script>


<style>
*{
 font-family: Helvetica;
 padding: 0;
 margin: 0;
 box-sizing: border-box;
}
.main-container{
 margin: 50px;
 min-height: 250px;
 height: 100%;  
}
h1{
 text-align: center;
 font-size: 42px;
 margin-bottom: 30px;
 color: #222;
}
</style>