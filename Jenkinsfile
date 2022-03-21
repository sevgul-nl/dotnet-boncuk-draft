pipeline {
    agent any
    tools {
        dotnetsdk 'pi-DOTNET 3.1.417'
    }

    environment {
        registry = 'sevgulnl/dotnet-eboncuk-draft'
        HOME = '.'
        JENKINS_USER = 'pi'
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
        sh 'echo "implement Test: Unit Test.."'
      //sh "dotnet test UnitTest_eBoncuk.csproj"
      }
    }

    stage('Test: Integration Test') {
      steps {
        sh 'echo "implement Test: Integration Test"'
      //sh "dotnet test ProjectPath\\IntegrateTest_eBoncuk.csproj"
      }
    }
    stage('Publish') {
      environment {   registryCredential = 'dockerhub'  }
      steps {
        sh 'dotnet publish eBoncuk.csproj '
        script {
            //sh 'docker stop $(docker ps -aqf "name=sevgulnl/snl-vue") && docker container prune -f -v $(docker ps -aqf "name=sevgulnl/snl-vue")'
            //sh 'docker image prune -f -v $(docker ps -aqf "name=sevgulnl/snl-vue")'

            def appimage = docker.build registry + ":$BUILD_NUMBER"
            docker.withRegistry( '', registryCredential ) {
            appimage.push()
            appimage.push('latest')
            }
          sh 'docker container rm msBoncuk --force'
          sh 'docker run -dp 8083:80   --name msBoncuk sevgulnl/dotnet-eboncuk-draft'
        }
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
