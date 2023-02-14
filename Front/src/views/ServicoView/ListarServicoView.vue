<template>
    <div class="main-container">
      <TabelaListarServico/>
    </div>
  </template>
  
  <script>
  import TabelaListarServico from '@/components/Servico/TabelaListarServico.vue';
  
  export default {
    name: 'ListarServicoView',
    components: {
      TabelaListarServico
    }
  }
  </script>