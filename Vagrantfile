Vagrant.configure("2") do |config|
    config.vm.define "devenviroment" do |devenviroment|
        devenviroment.vm.box = "ubuntu/trusty64"
        devenviroment.vm.network "forwarded_port", guest: 8080, host: 8080
        devenviroment.vm.network "private_network", ip: "192.168.200.10"

        devenviroment.vm.provider "virtualbox" do |vb|
            vb.name = "devenviroment"
            vb.memory = "1024"
            vb.cpus = 1
            #vb.customize ["modifyvm", :id, "--natdnshostresolver1", "on"]
            #vb.customize ["modifyvm", :id, "--natdnsproxy1", "on"]
        end

        devenviroment.vm.provision "shell", path: "installDockerCompose.sh"
        #ansibleJenServer.vm.provision "shell", path: "installAnsibleServer.sh"

        #ansibleJenServer.vm.synced_folder "./shared/jenkins", "/var/lib/jenkins", :mount_options => ["dmode=777", "fmode=666"]
        #ansibleJenServer.vm.synced_folder "./shared/sharedWithServer", "/home/vagrant/sharedWithServer", :mount_options => ["dmode=777", "fmode=666"]
        #ansibleJenServer.vm.synced_folder "./shared/cleintAuthorizedKeys", "/home/vagrant/authorizedkeys", :mount_options => ["dmode=777", "fmode=666"]
    end
end