<template>
    <div id="cadastro-vendedor">
      <h3>Atualizar item pedido</h3>
      <div class="form" style="padding: 1%;">
          <h3>Pedido - {{ this.cadastro.id }}</h3>
          <div>
              <label for="" class="form-label">Serviços Atual</label>
              <br>
              <input type="text" v-model="Servicos.nome" class="form-control" disabled>
          </div>
          <div>
              <label for="" class="form-label">Serviços Atualizado</label>
              <br>
              <select name="servicos" id="servicos" v-model="servicoAtualizadoId" class="form-select">
                  <option v-for="(servico, index) in Servicos" :key="index" :value="servico.id">{{ servico.nome }}</option>
              </select>
          </div>
          <div>
              <label for="" class="form-label">Quantidade</label>
              <br>
              <input type="number" v-model="cadastro.quantidade" class="form-control" min="1">
          </div>
          <div>
              <label for="" class="form-label">Valor</label>
              <br>
              <input type="number" v-model="cadastro.valor" class="form-control" min="1">
          </div>
          <button class="btn btn-success" style="margin-top: 4%;" @click="AtualizarItemPedido">Atualizar</button>
      </div>
    </div>
  </template>
  
  <script>
  import ServicoDataService from '../../services/ServicoDataService';
  import ItemPedidioDataService from '../../services/ItemPedidoDataService';  
  
  export default {
      name: "AtualizarItem",
      data(){
          return{
              cadastro: {
              },
              Dto:{
                pedidoId: "",
                servicoId: "",
                quantidade: "",
                valor: ""
              },
              servicoAtualizadoId: "",
              Servicos: [],
          }
      },
      methods: {
          AtualizarItemPedido(){
            this.MakeDto()
            console.log(this.Dto)
              if(Number(this.cadastro.quantidade) <= 0 || Number(this.cadastro.valor) <= 0){
                  alert("Quantidade e Valor devem ter no minimo 1")
              }
              else{
                  ItemPedidioDataService.atualizar(this.cadastro.id, this.Dto)
                  .then(() => {
                    this.$router.push('/itemPedido/pedido/'+this.cadastro.pedidoId)
                  })
              }
          },
          MakeDto(){
            this.Dto.pedidoId = this.cadastro.pedidoId
            this.Dto.servicoId = this.servicoAtualizadoId
            this.Dto.quantidade = this.cadastro.quantidade
            this.Dto.valor = this.cadastro.valor
          },
          getCadastro(){
            ItemPedidioDataService.obterPorId(this.$route.params.id)
            .then((response) => {
                this.cadastro = response.data
                console.log(response.data)
            })
          },
          getServicos(){
            ServicoDataService.listar()
            .then((response) => {
                this.Servicos = response.data
                this.Servicos = this.Servicos.filter(item => item.id !== this.cadastro.servico.id)
            })
          }
      },
      beforeMount(){
        this.getCadastro()
        this.getServicos()
      },
  }
  </script>
  
  <style>
  
  </style>