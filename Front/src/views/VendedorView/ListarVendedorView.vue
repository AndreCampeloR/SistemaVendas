<template>
    <div class="main-container">
      <TabelaListarVendedor/>
    </div>
  </template>
  
  <script>
  import TabelaListarVendedor from '@/components/Vendedor/TabelaListarVendedor.vue';
  
  export default {
    name: 'ListarVendedorView',
    components: {
      TabelaListarVendedor
    }
  }
  </script>