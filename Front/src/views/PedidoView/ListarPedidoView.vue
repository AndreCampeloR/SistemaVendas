<template>
    <div class="main-container">
      <TabelaListarPedido/>
    </div>
  </template>
  
  <script>
  import TabelaListarPedido from '../../components/Pedido/TabelaListarPedido.vue';
  
  export default {
    name: 'ListarPedidoView',
    components: {
      TabelaListarPedido
    }
  }
  </script>