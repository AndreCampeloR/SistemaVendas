<template>
    <div class="main-container">
      <FormCadastroPedido/>
    </div>
  </template>
  
  <script>
  import FormCadastroPedido from '../../components/Pedido/FormCadastroPedido.vue';

  export default {
    name: 'CadastrarCliente',
    components: {
      FormCadastroPedido
    }
  }
  </script>