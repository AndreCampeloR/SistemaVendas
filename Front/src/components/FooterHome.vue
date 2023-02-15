<template>
    <footer id="footer"> 
       <p>Sistema Vendas &copy; 2023</p>
    </footer>
</template>

<script>
export default {
    name: 'FooterHome'
}
</script>

<style scoped>
#footer{
    height: 200px;
    background-color: #222;
    border-top: 4px solid #111;
    color: #fCBA03;
    display: flex;
    align-items: center;
    justify-content: center;
    position: fixed;
    bottom: 0;
    width: 100%;    
}
</style>