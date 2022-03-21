pipeline {
    agent any

    environment {
        maven = 'pi-DOTNET 3.1.417'
        DOTNET_ROOT = '/home/pi/dotnet'
        PATH = '/home/pi/dotnet/:$PATH'
    }

  // triggers {
  //     pollSCM 'H * * * *'
  //}
  stages {
    //stage('Checkout') {
    //   steps {
    //    git credentialsId: "sevgul-nl", url: "https://github.com/sevgul-nl/Spring-Hibernate-Shopping-Draft.git/", branch: "master"
    //   }
    //}
    stage('Initialize') {
      steps {
        sh 'printenv DOTNET_ROOT'
        sh 'printenv PATH'
        sh 'dotnet --info'
      }
    }
    stage('Restore packages') {
      steps {
        sh 'dotnet restore eBoncuk.csproj'
      }
    }
    stage('Clean') {
      steps {
        sh 'dotnet clean eBoncuk.csproj'
      }
    }
    stage('Build') {
      steps {
        sh 'dotnet build eBoncuk.csproj --configuration Release'
      }
    }
    stage('Test: Unit Test') {
      steps {
        sh 'implement Test: Unit Test'
      //sh "dotnet test UnitTest_eBoncuk.csproj"
      }
    }

    stage('Test: Integration Test') {
      steps {
        sh 'implement Test: Integration Test'
      //sh "dotnet test ProjectPath\\IntegrateTest_eBoncuk.csproj"
      }
    }
    stage('Publish') {
      steps {
        sh 'dotnet publish eBoncuk.csproj '
      }
    }
  //post{
  //  always{
  //    emailext body: "${currentBuild.currentResult}: Job   ${env.JOB_NAME} build ${env.BUILD_NUMBER}\n More info at: ${env.BUILD_URL}",
  //    recipientProviders: [[$class: 'DevelopersRecipientProvider'], [$class: 'RequesterRecipientProvider']],
  //    subject: "Jenkins Build ${currentBuild.currentResult}: Job ${env.JOB_NAME}"
  //   }
  //  }
  }
}
