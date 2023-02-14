<template>
    <div class="main-container">
      <FormCadastroServico/>
    </div>
  </template>
  
  <script>
  import FormCadastroServico from '@/components/Servico/FormCadastroServico.vue';

  export default {
    name: 'CadastrarServicoView',
    components: {
      FormCadastroServico
    }
  }
  </script>