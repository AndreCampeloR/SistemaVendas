<template>
    <div class="main-container">
      <TabelaListarItem/>
    </div>
  </template>
  
  <script>
  import TabelaListarItem from '@/components/itemPedido/TabelaListarItem.vue';
  
  export default {
    name: 'ListarItemView',
    components: {
      TabelaListarItem
    }
  }
  </script>